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
                    new("CustomerId", "CUSTOMER_ID", "int", false, true, 12, 1, 2, false)
                },
                OneToOneRelationships = new List<OneToOneRelationship>
                {
                    new("Test", "Customer", "CustomerId",true,DeleteBehavior.NoAction)
                },
                // OneToManyRelationships = new List<OneToManyRelationship>()
                // {
                //     new("Test","CustomerResponses","TestId",false,DeleteBehavior.Cascade)
                // },
                ManyToManyRelationships = new List<ManyToManyRelationships>()
                {
                    new("Tests","CustomerResponses")
                },
                OneEntities = new []{ "Customer" },
                CollectionEntities = new []{ "CustomerResponse" }
            };
        }
    }
}