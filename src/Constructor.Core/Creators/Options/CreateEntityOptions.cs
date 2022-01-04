using Constructor.Core.Models;

namespace Constructor.Core.Creators.Options
{
    public class CreateEntityOptions
    {
        public CreateEntityOptions(EntityOptions entityOptions, string path)
        {
            EntityOptions = entityOptions;
            Path = path;
        }

        public EntityOptions EntityOptions { get; }
        public string Path { get; }
    }
}