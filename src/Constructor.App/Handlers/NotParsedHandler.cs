using System;
using System.Collections.Generic;
using System.Reflection;
using CommandLine;

namespace Constructor.App.Handlers
{
    public static class NotParsedHandler
    {
        public static void Handle(IEnumerable<Error> errs)
        {
            if (errs.IsVersion())
            {
                var version = Assembly.GetEntryAssembly()?
                    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                    .InformationalVersion;
                Console.WriteLine($"v{version}");
                return;
            }

            if (errs.IsHelp())
            {
                Console.WriteLine("Help Request");
            }
        }
    }
}