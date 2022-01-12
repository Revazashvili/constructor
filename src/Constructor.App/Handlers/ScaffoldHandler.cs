using System;
using System.IO;
using System.Net;
using System.Text.Json;
using Constructor.App.Models;
using Constructor.App.Options;

namespace Constructor.App.Handlers
{
    public static class ScaffoldHandler
    {
        public static void Handle(ScaffoldOptions scaffoldOptions)
        {
            if (string.IsNullOrEmpty(scaffoldOptions.ConfigPath))
            {
                Console.WriteLine("Configuration file path must be specified.");
                return;
            }

            var configurationText = File.ReadAllText(scaffoldOptions.ConfigPath);
            var configuration = JsonSerializer.Deserialize<Configuration>(configurationText);
            Console.WriteLine("Scaffold handler works!");
            Console.WriteLine(configuration.Database.Provider);
        }
    }
}