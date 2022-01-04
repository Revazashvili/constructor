using Constructor.Core.Models;

namespace Constructor.Core.Creators.Options
{
    public class CreateContextOptions
    {
        public CreateContextOptions(ContextOptions contextOptions, string path)
        {
            ContextOptions = contextOptions;
            Path = path;
        }

        public ContextOptions ContextOptions { get; set; }
        public string Path { get; set; }
    }
}