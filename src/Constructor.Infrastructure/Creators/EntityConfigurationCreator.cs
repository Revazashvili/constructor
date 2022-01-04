using Constructor.Core.Constructors;
using Constructor.Core.Creators;
using Constructor.Core.Creators.Options;
using Constructor.Core.Managers;

namespace Constructor.Infrastructure.Creators
{
    public class EntityConfigurationCreator : IEntityConfigurationCreator
    {
        private readonly IEntityConfigurationConstructor _entityConfigurationConstructor;
        private readonly IFileManager _fileManager;

        public EntityConfigurationCreator(IEntityConfigurationConstructor entityConfigurationConstructor,
            IFileManager fileManager)
        {
            _entityConfigurationConstructor = entityConfigurationConstructor;
            _fileManager = fileManager;
        }

        public void Create(CreateEntityConfigurationOptions createEntityConfigurationOptions)
        {
            var construction =
                _entityConfigurationConstructor.Construct(createEntityConfigurationOptions.EntityOptions);
            var pathToFile =
                $@"{createEntityConfigurationOptions.Path}\{createEntityConfigurationOptions.EntityOptions.Name}Configuration.cs";
            _fileManager.Save(pathToFile, construction);
        }
    }
}