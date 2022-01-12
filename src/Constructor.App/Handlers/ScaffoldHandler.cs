using System;
using Constructor.App.Options;

namespace Constructor.App.Handlers
{
    public static class ScaffoldHandler
    {
        public static void Handle(ScaffoldOptions scaffoldOptions)
        {
            Console.WriteLine("Scaffold handler works!");
            Console.WriteLine(scaffoldOptions.ConfigPath);
        }
    }
}