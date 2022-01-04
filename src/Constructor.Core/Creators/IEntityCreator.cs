using Constructor.Core.Creators.Options;

namespace Constructor.Core.Creators
{
    public interface IEntityCreator
    {
        void Create(CreateEntityOptions createEntityOptions);
    }
}