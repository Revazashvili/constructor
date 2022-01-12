using CommandLine;

namespace Constructor.App.Options
{
    [Verb("scaffold",true,HelpText = "Scaffold database.")]
    public class ScaffoldOptions
    {
        [Option(Required = true, HelpText = "path to config file for constructor.")]
        public string ConfigPath { get; set; }
    }
}