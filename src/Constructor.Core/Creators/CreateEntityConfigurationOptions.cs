using Constructor.Core.Models;

namespace Constructor.Core.Creators
{
    public class CreateEntityConfigurationOptions
    {
        public CreateEntityConfigurationOptions(EntityOptions entityOptions, string path)
        {
            EntityOptions = entityOptions;
            Path = path;
        }

        public EntityOptions EntityOptions { get; set; }
        public string Path { get; set; }
    }
}