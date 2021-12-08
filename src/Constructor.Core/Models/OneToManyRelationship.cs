using Microsoft.EntityFrameworkCore;

namespace Constructor.Core.Models
{
    public class OneToManyRelationship
    {
        public OneToManyRelationship(
            string leftEntity,
            string rightEntity,
            string fkProperty,
            bool isRequired,
            DeleteBehavior deleteBehavior)
        {
            LeftEntity = leftEntity;
            RightEntity = rightEntity;
            FkProperty = fkProperty;
            IsRequired = isRequired;
            DeleteBehavior = deleteBehavior;
        }

        public string LeftEntity { get; }
        public string RightEntity { get; }
        public string FkProperty { get; }
        public bool IsRequired { get; }
        public DeleteBehavior DeleteBehavior { get; }
    }
}