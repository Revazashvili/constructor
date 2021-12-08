using System;
using Constructor.Core;
using Constructor.Core.Creators;
using Constructor.Core.Providers;


const string entitiesFolderPath = @"D:\Projects\constructor\src\TestClient\Entities";
const string configurationFolderPath = @"D:\Projects\constructor\src\TestClient\Configurations";
Console.WriteLine("Start building...");
var entityOptionsProvider = new EntityOptionsProvider();
var entityOptions = entityOptionsProvider.Provide();
var entityCreator = CreatorProvider.GetEntityCreator();
var entityConfigurationCreator = CreatorProvider.GetEntityConfigurationCreator();

entityCreator.Create(new CreateEntityOptions(entityOptions, entitiesFolderPath));
entityConfigurationCreator.Create(new CreateEntityConfigurationOptions(entityOptions, configurationFolderPath));

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


// namespace TestClient
// {
//     internal static class Program
//     {
//         private static void Main(string[] args)
//         {
//              try
//              {
//                  const string connectionString =
//                      @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=ibank-db-test.bog.ge)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=CIB03)));password=cib;user id=CIB";
//                  var prefixesToRemove = new[] {"CIB", "ZZ"};
//                  var suffixesToRemove = new[] {"CIB03"};
//                  var connectionManager = new OracleConnectionManager(connectionString);
//                  var repo = new OracleRepository(connectionManager);
//                  var tableNames = repo.GetTableNames().Take(10);
//                  Console.WriteLine("some_title for something".Pascalize());
//                  foreach (var tableName in tableNames)
//                      Console.WriteLine(tableName.Pascalize().RemovePrefixes(prefixesToRemove)
//                          .RemoveSuffixes(suffixesToRemove));
//             
//                  var table = repo.GetTableInfo("CIB_ONBOARDING_PRODUCT_TITLE");
//                  Console.WriteLine(JsonSerializer.Serialize(table));
//             
//                  Console.WriteLine("CUSTOMERS".Pluralize().ToUpper());
//              }
//              catch (Exception e)
//              {
//                  Console.WriteLine(e);
//              }
//         }
//     }
// }