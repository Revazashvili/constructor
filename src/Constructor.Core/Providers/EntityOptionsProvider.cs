using System.Collections.Generic;
using Constructor.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Constructor.Core.Providers
{
    public class EntityOptionsProvider : IEntityOptionsProvider
    {
        public EntityOptions Provide()
        {
            return new EntityOptions
            {
                Name = "Test",
                Namespace = "TestClient.Entities",
                IsTable = true,
                SchemaName = "dbo",
                TableOrViewName = "TEST",
                Properties = new List<PropertyOptions>
                {
                    new("Id", "ID", "int", true, true, 0, 0, 0, false),
                    new("FirstName", "FIRSTNAME", "string", false, true, 20, 1, 2, true),
                    new("LastName", "LASTNAME", "string", false, true, 12, 1, 2, false),
                    new("Test2Id", "TEST2_ID", "int", false, true, 12, 1, 2, false)
                },
                OneToOneRelationships = new List<OneToOneRelationship>
                {
                    new("Test", "Test2", "Test2Id", DeleteBehavior.NoAction)
                }
            };
        }
    }
}