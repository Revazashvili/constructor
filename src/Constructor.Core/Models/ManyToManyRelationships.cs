namespace Constructor.Core.Models
{
    public class ManyToManyRelationships
    {
        public ManyToManyRelationships(
            string rightEntity,
            string leftEntity)
        {
            RightEntity = rightEntity;
            LeftEntity = leftEntity;
        }

        public string RightEntity { get; }
        public string LeftEntity { get; }
    }
}