using Constructor.Core.Creators.Options;

namespace Constructor.Core.Creators
{
    public interface IEntityConfigurationCreator
    {
        void Create(CreateEntityConfigurationOptions createEntityConfigurationOptions);
    }
}