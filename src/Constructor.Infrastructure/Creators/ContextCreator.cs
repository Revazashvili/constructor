using Constructor.Core.Constructors;
using Constructor.Core.Creators;
using Constructor.Core.Creators.Options;
using Constructor.Core.Managers;

namespace Constructor.Infrastructure.Creators
{
    public class ContextCreator : IContextCreator
    {
        private readonly IContextConstructor _contextConstructor;
        private readonly IFileManager _fileManager;

        public ContextCreator(IContextConstructor contextConstructor,IFileManager fileManager)
        {
            _contextConstructor = contextConstructor;
            _fileManager = fileManager;
        }

        public void Create(CreateContextOptions createContextOptions)
        {
            var construction = _contextConstructor.Constructor(createContextOptions.ContextOptions);
            var pathToFile = $@"{createContextOptions.Path}\{createContextOptions.ContextOptions.Name}.cs";
            _fileManager.Save(pathToFile, construction);
        }
    }
}