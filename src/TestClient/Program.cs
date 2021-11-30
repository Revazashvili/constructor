using System;
using Constructor.Core.Constructors;
using Constructor.Core.Creators;
using Constructor.Core.Managers;
using Constructor.Core.Providers;

const string entitiesFolderPath = @"C:\Projects\NetCore\constructor\src\TestClient\Entities";
const string configurationFolderPath = @"C:\Projects\NetCore\constructor\src\TestClient\Configurations";
Console.WriteLine("Start building...");
var entityOptionsProvider = new EntityOptionsProvider();
var entityOptions = entityOptionsProvider.Provide();

var fileManager = new FileManager();
var entityConstructor = new EntityConstructor();
var entityConfigurationConstructor = new EntityConfigurationConstructor();
var entityCreator = new EntityCreator(entityConstructor, fileManager);
var entityConfigurationCreator = new EntityConfigurationCreator(entityConfigurationConstructor, fileManager);

entityCreator.Create(new CreateEntityOptions(entityOptions,entitiesFolderPath));
entityConfigurationCreator.Create(new CreateEntityConfigurationOptions(entityOptions, configurationFolderPath));

//BuildEntity(entityOptions);
//BuildConfiguration(entityOptions);


// void BuildEntity(EntityOptions entityOptions2)
// {
//     var entity = new Entity
//     {
//         EntityOptions = entityOptions2
//     };
//
//     var entitiesFolderPath = @"C:\Projects\NetCore\constructor\src\TestClient\Entities";
//     var filePath = $@"{entitiesFolderPath}\{entityOptions2.Name}.cs";
//     var fileContent = entity.TransformText();
//     var file = new FileInfo(filePath);
//     file.Directory?.Create();
//     File.WriteAllText(filePath, fileContent);
//     Console.WriteLine("Entity is built");
// }
//
// void BuildConfiguration(EntityOptions? entityOptions1)
// {
//     var entityConfiguration = new EntityConfiguration
//     {
//         EntityOptions = entityOptions1
//     };
//
//     var configurationFolderPath = @"C:\Projects\NetCore\constructor\src\TestClient\Configurations";
//     var filePathConf = $@"{configurationFolderPath}\{entityOptions1.Name}Configuration.cs";
//     var confFileContent = entityConfiguration.TransformText();
//     var confFile = new FileInfo(filePathConf);
//     confFile.Directory?.Create();
//     File.WriteAllText(filePathConf, confFileContent);
//     Console.WriteLine("Configuration is built");
// }