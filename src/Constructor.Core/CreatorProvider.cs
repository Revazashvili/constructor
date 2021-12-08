using Constructor.Core.Constructors;
using Constructor.Core.Creators;
using Constructor.Core.Managers;

namespace Constructor.Core
{
    public static class CreatorProvider
    {
        private static readonly IFileManager FileManager = new FileManager();
        private static readonly IEntityConstructor EntityConstructor = new EntityConstructor();

        private static readonly IEntityConfigurationConstructor EntityConfigurationConstructor =
            new EntityConfigurationConstructor();

        public static EntityCreator GetEntityCreator()
        {
            return new EntityCreator(EntityConstructor, FileManager);
        }

        public static EntityConfigurationCreator GetEntityConfigurationCreator()
        {
            return new EntityConfigurationCreator(EntityConfigurationConstructor, FileManager);
        }
    }
}