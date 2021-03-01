using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Microsoft.Graph.PowerShell.Authentication.Utilities
{
    public static class DependencyAssemblyResolver
    {
        // We catalog our dependencies here to ensure we don't load anything else
        private static IReadOnlyDictionary<string, int> s_dependencies = new Dictionary<string, int>
        {
            { "Microsoft.Identity.Client", 4 },
        };

        // Set up the path to our dependency directory within the module
        private static string s_dependenciesDirPath = Path.GetFullPath(
            Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "Dependencies"));

        // This makes sure we only try to resolve dependencies when the module is loaded
        private static bool s_engineLoaded = false;

        public static void Initialize()
        {
            Console.WriteLine($"Initialize");
            // Set up our event when the module is loaded
            AppDomain.CurrentDomain.AssemblyResolve += HandleResolveEvent;
        }

        private static Assembly HandleResolveEvent(object sender, ResolveEventArgs args)
        {
            var asmName = new AssemblyName(args.Name);
            Console.WriteLine($"Loading: {asmName.Name}");
            // First we want to know if this is the top-level assembly
            if (asmName.Name.Equals("Microsoft.Graph.Authentication.Core"))
            {
                s_engineLoaded = true;
                return Assembly.LoadFile(Path.Combine(s_dependenciesDirPath, "Microsoft.Graph.Authentication.Core.dll"));
            }

            // Otherwise, if that assembly has been loaded, we must try to resolve its dependencies too
            if (s_engineLoaded
                && s_dependencies.TryGetValue(asmName.Name, out int requiredMajorVersion)
                && asmName.Version.Major == requiredMajorVersion)
            {
                string asmPath = Path.Combine(s_dependenciesDirPath, $"{asmName.Name}.dll");
                Console.WriteLine($"Loading for engine assembly: {asmName.Name}");
                return Assembly.LoadFile(asmPath);
            }

            return null;
        }
    }
}
