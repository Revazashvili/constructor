using System;
using System.Linq;
using System.Reflection;
using CommandLine;
using Constructor.App.Handlers;

namespace Constructor.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var verbs = GetAllVerbs();
            Parser.Default.ParseArguments(args,verbs)
                .WithParsed(ParsedHandler.Handle)
                .WithNotParsed(NotParsedHandler.Handle);
        }
        private static Type[] GetAllVerbs()
        {
            return Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetCustomAttribute<VerbAttribute>() != null).ToArray();	
        }
    }
}