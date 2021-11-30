using Constructor.Core.Constructors;
using Constructor.Core.Managers;

namespace Constructor.Core.Creators
{
    public class EntityCreator : IEntityCreator
    {
        private readonly IEntityConstructor _entityConstructor;
        private readonly IFileManager _fileManager;

        public EntityCreator(IEntityConstructor entityConstructor, IFileManager fileManager)
        {
            _entityConstructor = entityConstructor;
            _fileManager = fileManager;
        }

        public void Create(CreateEntityOptions createEntityOptions)
        {
            string construction = _entityConstructor.Construct(createEntityOptions.EntityOptions);
            var pathToFile = $@"{createEntityOptions.Path}\{createEntityOptions.EntityOptions.Name}.cs";
            _fileManager.Save(pathToFile, construction);
        }
    }
}