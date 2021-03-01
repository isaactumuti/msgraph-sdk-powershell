using Microsoft.Graph.Auth;
using Microsoft.Graph.PowerShell.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.Authentication.Core
{
    public static class Authenticator
    {
        public static async Task<IAuthContext> AuthenticateAsync(IAuthContext authContext, bool forceRefresh, CancellationToken cancellationToken)
        {
            try
            {
                // Gets a static instance of IAuthenticationProvider when the client app hasn't changed.
                IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(authContext);
                IClientApplicationBase clientApplication = null;
                if (authContext.AuthType == AuthenticationType.Delegated)
                {
                    clientApplication = (authProvider as DeviceCodeProvider).ClientApplication;
                }
                else if (authContext.AuthType == AuthenticationType.AppOnly)
                {
                    clientApplication = (authProvider as ClientCredentialProvider).ClientApplication;
                }

                // Incremental scope consent without re-instantiating the auth provider. We will use a static instance.
                GraphRequestContext graphRequestContext = new GraphRequestContext();
                graphRequestContext.CancellationToken = cancellationToken;
                graphRequestContext.MiddlewareOptions = new Dictionary<string, IMiddlewareOption>
                {
                    {
                        typeof(AuthenticationHandlerOption).ToString(),
                        new AuthenticationHandlerOption
                        {
                            AuthenticationProviderOption = new AuthenticationProviderOption
                            {
                                Scopes = authContext.Scopes,
                                ForceRefresh = forceRefresh
                            }
                        }
                    }
                };

                // Trigger consent.
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://graph.microsoft.com/v1.0/me");
                httpRequestMessage.Properties.Add(typeof(GraphRequestContext).ToString(), graphRequestContext);
                await authProvider.AuthenticateRequestAsync(httpRequestMessage);

                IAccount account = null;
                if (clientApplication != null)
                {
                    // Only get accounts when we are using MSAL to get an access token.
                    IEnumerable<IAccount> accounts = clientApplication.GetAccountsAsync().GetAwaiter().GetResult();
                    account = accounts.FirstOrDefault();
                }

                return authContext;
            }
            catch (AuthenticationException authEx)
            {
                if ((authEx.InnerException is TaskCanceledException) && cancellationToken.IsCancellationRequested)
                {
                    // DeviceCodeTimeout
                    throw new Exception(string.Format(
                            CultureInfo.CurrentCulture,
                            ErrorConstants.Message.DeviceCodeTimeout,
                            Constants.MaxDeviceCodeTimeOut));
                }
                else
                {
                    throw authEx.InnerException ?? authEx;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
