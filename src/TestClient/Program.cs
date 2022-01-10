using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Constructor.Core;
using Constructor.Core.Constructors;
using Constructor.Core.Creators;
using Constructor.Core.Creators.Options;
using Constructor.Core.Managers;
using Constructor.Core.Models;
using Constructor.Core.Providers;
using Constructor.Infrastructure.Constructors;
using Constructor.Infrastructure.Creators;
using Constructor.Infrastructure.Managers;
using Constructor.Infrastructure.Providers;
using Constructor.Infrastructure.Repositories;
using Humanizer;

// const string entitiesFolderPath = @"D:\Projects\constructor\src\TestClient\GeneratedModels\Entities";
// const string configurationFolderPath = @"D:\Projects\constructor\src\TestClient\GeneratedModels\Configurations";
// const string contextFolderPath = @"D:\Projects\constructor\src\GeneratedModels\TestClient";
// Console.WriteLine("Start building...");
// var entityOptionsProvider = new EntityOptionsProvider();
// var entityOptions = entityOptionsProvider.Provide();
// IFileManager fileManager = new FileManager();
//
// IEntityConstructor entityConstructor = new EntityConstructor();
// IEntityCreator entityCreator = new EntityCreator(entityConstructor, fileManager);
//
// IEntityConfigurationConstructor entityConfigurationConstructor = new EntityConfigurationConstructor();
// IEntityConfigurationCreator entityConfigurationCreator = new EntityConfigurationCreator(entityConfigurationConstructor,fileManager);
//
// IContextConstructor contextConstructor = new ContextConstructor();
// IContextCreator contextCreator = new ContextCreator(contextConstructor,fileManager);
//
//
// entityCreator.Create(new CreateEntityOptions(entityOptions, entitiesFolderPath));
// entityConfigurationCreator.Create(new CreateEntityConfigurationOptions(entityOptions, configurationFolderPath));
// contextCreator.Create(new CreateContextOptions(new ContextOptions
// {
//     Name = "CibContext",
//     Namespace = "GeneratedModels.TestClient",
//     EntitiesNamespace = "TestClient.GeneratedModels.Entities",
//     Entities = new[] {"Test", "Customer", "CustomerResponse"}
// }, contextFolderPath));
//
// Console.WriteLine("Done");

// var x = new EntityOptions
// {
//     Name = "Test2",
//     Namespace = "TestClient.Entities",
//     IsTable = true,
//     SchemaName = "dbo",
//     TableOrViewName = "TEST2",
//     Properties = new List<PropertyOptions>
//     {
//         new("Id", "ID", "int", true, true, 0, 0, 0, false)
//     },
//     OneToOneRelationships = new List<OneToOneRelationship>
//     {
//         new("Test2", "Test", "TestId", DeleteBehavior.NoAction)
//     }
// };
// entityCreator.Create(new CreateEntityOptions(x, entitiesFolderPath));


namespace TestClient
{
    static class Program
    {
        public static async Task Main(string[] args)
        {
            try
            {
                const string connectionString =
                    @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=ibank-db-test.bog.ge)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=CIB03)));password=cib;user id=CIB";
                // var prefixesToRemove = new[] {"CIB", "ZZ"};
                // var suffixesToRemove = new[] {"CIB03"};
                var connectionManager = new OracleConnectionManager(connectionString);
                var repo = new OracleRepository(connectionManager);
                var cibSchema = (await repo.GetSchemas()).FirstOrDefault(schema => schema == "CIB");
                var customersTable = (await repo.GetTables(cibSchema)).FirstOrDefault(table => table == "CIB_CUSTOMERS");
                var columns = await repo.GetColumns(customersTable);
                foreach (var column in columns)
                {
                    Console.WriteLine(column.ToString());
                    Console.WriteLine(column.ColumnName.ToLower().Pascalize());
                }

                Console.WriteLine($"Table In Normal Letters: {customersTable.ToLower().Pascalize()}");

                var entityOptions = new EntityOptions
                {
                    Name = customersTable.ToLower().Pascalize(),
                    TableOrViewName = customersTable,
                    Namespace = "TestClient.GeneratedModels.Entities",
                    IsTable = true,
                    SchemaName = cibSchema,
                };
                foreach (var column in columns)
                {
                    var property = new PropertyOptions(column.ColumnName.ToLower().Pascalize(), column.ColumnName,
                        column.DataType, column.IsPrimaryKey, column.IsRequired, column.Length, column.Precision,
                        column.Scale, column.IsUnicode);
                    entityOptions.Properties.Add(property);
                }

                Console.WriteLine(entityOptions.Name);
                // var tableNames = repo.GetTableNames().Take(10);
                // Console.WriteLine("some_title for something".Pascalize());
                // foreach (var tableName in tableNames)
                // {
                //     Console.WriteLine(tableName.Pascalize().RemovePrefixes(prefixesToRemove)
                //         .RemoveSuffixes(suffixesToRemove));
                // }

                // var table = repo.GetTableInfo("CIB_ONBOARDING_PRODUCT_TITLE");
                // Console.WriteLine(JsonSerializer.Serialize(table));

                //Console.WriteLine("CUSTOMERS".Pluralize().ToUpper());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}