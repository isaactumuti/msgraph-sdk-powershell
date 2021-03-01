﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    using Microsoft.Graph.Auth;
    using Microsoft.Graph.PowerShell.Authentication.Models;
    using Microsoft.Graph.PowerShell.Authentication.TokenCache;
    using Microsoft.Identity.Client;

    using System;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Net.Http.Headers;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;
    using System.Threading.Tasks;

    using AuthenticationException = System.Security.Authentication.AuthenticationException;

    public static class AuthenticationHelpers
    {
        static ReaderWriterLockSlim _cacheLock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);

        public static IAuthenticationProvider GetAuthProvider(IAuthContext authContext)
        {
            if (authContext is null)
            {
                throw new AuthenticationException("ErrorConstants.Message.MissingAuthContext");
            }

            IAuthenticationProvider authProvider = null;
            string authorityUrl = GetAuthorityUrl(authContext);
            switch (authContext.AuthType)
            {
                case AuthenticationType.Delegated:
                    {
                        IPublicClientApplication publicClientApp = PublicClientApplicationBuilder
                        .Create(authContext.ClientId)
                        .WithTenantId(authContext.TenantId)
                        .WithAuthority(authorityUrl)
                        .Build();

                        ConfigureTokenCache(publicClientApp.UserTokenCache, authContext);
                        authProvider = new DeviceCodeProvider(publicClientApp, authContext.Scopes, async (result) =>
                        {
                            await Console.Out.WriteLineAsync(result.Message);
                        });
                        break;
                    }
                case AuthenticationType.AppOnly:
                    {
                        IConfidentialClientApplication confidentialClientApp = ConfidentialClientApplicationBuilder
                        .Create(authContext.ClientId)
                        .WithTenantId(authContext.TenantId)
                        .WithAuthority(authorityUrl)
                        .WithCertificate(GetCertificate(authContext))
                        .Build();

                        ConfigureTokenCache(confidentialClientApp.AppTokenCache, authContext);
                        string graphBaseUrl = GraphSession.Instance.Environment?.GraphEndpoint ?? "https://graph.microsoft.com";
                        authProvider = new ClientCredentialProvider(confidentialClientApp, $"{graphBaseUrl}/.default");
                        break;
                    }
                case AuthenticationType.UserProvidedAccessToken:
                    {
                        authProvider = new DelegateAuthenticationProvider((requestMessage) =>
                        {
                            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer",
                                new NetworkCredential(string.Empty, GraphSession.Instance.UserProvidedToken).Password);
                            return Task.CompletedTask;
                        });
                        break;
                    }
            }
            return authProvider;
        }
        /// <summary>
        ///     Gets a certificate based on the current context.
        ///     Priority is Name, ThumbPrint, then In-Memory Cert
        /// </summary>
        /// <param name="context">Current <see cref="IAuthContext"/> context</param>
        /// <returns>A <see cref="X509Certificate2"/> based on provided <see cref="IAuthContext"/> context</returns>
        private static X509Certificate2 GetCertificate(IAuthContext context)
        {
            X509Certificate2 certificate;
            if (!string.IsNullOrWhiteSpace(context.CertificateName))
            {
                certificate = GetCertificateByName(context.CertificateName);
            }
            else if (!string.IsNullOrWhiteSpace(context.CertificateThumbprint))
            {
                certificate = GetCertificateByThumbprint(context.CertificateThumbprint);
            }
            else
            {
                certificate = context.Certificate;
            }

            if (certificate == null)
            {
                throw new ArgumentNullException(nameof(certificate), $"Certificate with the Specified ThumbPrint {context.CertificateThumbprint}, Name {context.CertificateName} or In-Memory could not be found");
            }

            return certificate;
        }

        private static string GetAuthorityUrl(IAuthContext authContext)
        {
            string audience = authContext.TenantId ?? GraphEnvironmentConstants.CommonAdTenant;
            string defaultInstance = GraphEnvironment.BuiltInEnvironments[GraphEnvironmentConstants.EnvironmentName.Global].AzureADEndpoint;
            string authorityUrl = $"{defaultInstance}/{audience}";

            if (GraphSession.Instance.Environment != null)
            {
                authorityUrl = $"{GraphSession.Instance.Environment.AzureADEndpoint}/{audience}";
            }

            return authorityUrl;
        }

        public static void Logout(IAuthContext authConfig)
        {
            try
            {
                _cacheLock.EnterWriteLock();
                if (authConfig.AuthType == AuthenticationType.UserProvidedAccessToken)
                {
                    GraphSession.Instance.UserProvidedToken = null;
                }
                else
                {
                    TokenCacheStorage.DeleteToken(authConfig);
                }
            }
            finally
            {
                _cacheLock.ExitWriteLock();
            }
        }

        private static void ConfigureTokenCache(ITokenCache tokenCache, IAuthContext authContext)
        {
            tokenCache.SetBeforeAccess((TokenCacheNotificationArgs args) =>
            {
                try
                {
                    _cacheLock.EnterReadLock();
                    args.TokenCache.DeserializeMsalV3(TokenCacheStorage.GetToken(authContext), shouldClearExistingCache: true);
                }
                finally
                {
                    _cacheLock.ExitReadLock();
                }
            });

            tokenCache.SetAfterAccess((TokenCacheNotificationArgs args) =>
            {
                if (args.HasStateChanged)
                {
                    try
                    {
                        _cacheLock.EnterWriteLock();
                        TokenCacheStorage.SetToken(authContext, args.TokenCache.SerializeMsalV3());
                    }
                    finally
                    {
                        _cacheLock.ExitWriteLock();
                    }
                }
            });
        }

        /// <summary>
        /// Gets unexpired certificate of the specified certificate thumbprint for the current user in My store.
        /// </summary>
        /// <param name="certificateThumbprint">Subject name of the certificate to get.</param>
        /// <returns></returns>
        private static X509Certificate2 GetCertificateByThumbprint(string certificateThumbprint)
        {
            X509Certificate2 xCertificate = null;

            using (X509Store xStore = new X509Store(StoreName.My, StoreLocation.CurrentUser))
            {
                xStore.Open(OpenFlags.ReadOnly);

                // Get unexpired certificates with the specified name.
                X509Certificate2Collection unexpiredCerts = xStore.Certificates
                    .Find(X509FindType.FindByTimeValid, DateTime.Now, false)
                    .Find(X509FindType.FindByThumbprint, certificateThumbprint, false);

                if (unexpiredCerts.Count < 1)
                    throw new Exception($"{certificateThumbprint} certificate was not found or has expired.");

                // Only return current cert.
                xCertificate = unexpiredCerts
                    .OfType<X509Certificate2>()
                    .OrderByDescending(c => c.NotBefore)
                    .FirstOrDefault();
            }
            return xCertificate;
        }

        /// <summary>
        /// Gets unexpired certificate of the specified certificate subject name for the current user in My store.
        /// </summary>
        /// <param name="certificateName">Subject name of the certificate to get.</param>
        /// <returns></returns>
        private static X509Certificate2 GetCertificateByName(string certificateName)
        {
            X509Certificate2 xCertificate = null;

            using (X509Store xStore = new X509Store(StoreName.My, StoreLocation.CurrentUser))
            {
                xStore.Open(OpenFlags.ReadOnly);

                // Get unexpired certificates with the specified name.
                X509Certificate2Collection unexpiredCerts = xStore.Certificates
                    .Find(X509FindType.FindByTimeValid, DateTime.Now, false)
                    .Find(X509FindType.FindBySubjectDistinguishedName, certificateName, false);

                if (unexpiredCerts.Count < 1)
                    throw new Exception($"{certificateName} certificate was not found or has expired.");

                // Only return current cert.
                xCertificate = unexpiredCerts
                    .OfType<X509Certificate2>()
                    .OrderByDescending(c => c.NotBefore)
                    .FirstOrDefault();
            }
            return xCertificate;
        }

        private static void DecodeJWT(string token, IAccount account, ref IAuthContext authContext)
        {
            JwtPayload jwtPayload = JwtHelpers.DecodeToObject<JwtPayload>(token);
            if (authContext.AuthType == AuthenticationType.UserProvidedAccessToken)
            {
                if (jwtPayload == null)
                {
                    throw new Exception(string.Format(
                            CultureInfo.CurrentCulture,
                            ErrorConstants.Message.InvalidUserProvidedToken,
                            "AccessToken"));
                }

                if (jwtPayload.Exp <= JwtHelpers.ConvertToUnixTimestamp(DateTime.UtcNow + TimeSpan.FromMinutes(Constants.TokenExpirationBufferInMinutes)))
                {
                    throw new Exception(string.Format(
                            CultureInfo.CurrentCulture,
                            ErrorConstants.Message.ExpiredUserProvidedToken,
                            "AccessToken"));
                }
            }

            authContext.ClientId = jwtPayload?.Appid ?? authContext.ClientId;
            authContext.Scopes = jwtPayload?.Scp?.Split(' ') ?? jwtPayload?.Roles;
            authContext.TenantId = jwtPayload?.Tid ?? account?.HomeAccountId?.TenantId;
            authContext.AppName = jwtPayload?.AppDisplayname;
            authContext.Account = jwtPayload?.Upn ?? account?.Username;
        }
    }
}