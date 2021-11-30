using Microsoft.EntityFrameworkCore;

namespace Constructor.Core.Models
{
    public class OneToOneRelationship
    {
        public OneToOneRelationship(string pkEntity, string fkEntity, string fkProperty, DeleteBehavior deleteBehavior)
        {
            PkEntity = pkEntity;
            FkEntity = fkEntity;
            FkProperty = fkProperty;
            DeleteBehavior = deleteBehavior;
        }

        public string PkEntity { get; set; }
        public string FkEntity { get; set; }
        public string FkProperty { get; set; }
        public DeleteBehavior DeleteBehavior { get; set; }
    }
}