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

        private static readonly IContextConstructor ContextConstructor = new ContextConstructor();

        public static EntityCreator GetEntityCreator() => new EntityCreator(EntityConstructor, FileManager);
        public static EntityConfigurationCreator GetEntityConfigurationCreator() => new EntityConfigurationCreator(EntityConfigurationConstructor, FileManager);
        public static ContextCreator GetContextCreator() => new ContextCreator(ContextConstructor, FileManager);
    }
}