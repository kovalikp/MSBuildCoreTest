using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MSBuildCoreTest
{
    class Locator
    {
        private const string MSBuildSdkPath = @"c:\Program Files\dotnet\sdk\2.1.201";

        public static void Setup()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (_, eventArgs) =>
            {
                var assemblyName = new AssemblyName(eventArgs.Name);
                var targetAssembly = Path.Combine(MSBuildSdkPath, assemblyName.Name + ".dll");
                return File.Exists(targetAssembly) ? Assembly.LoadFrom(targetAssembly) : null;
            };

        }
    }
}
