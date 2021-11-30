using System;
using System.Collections.Generic;
using Constructor.Core.Constructors;
using Constructor.Core.Creators;
using Constructor.Core.Managers;
using Constructor.Core.Models;
using Constructor.Core.Providers;
using Microsoft.EntityFrameworkCore;

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

entityCreator.Create(new CreateEntityOptions(entityOptions, entitiesFolderPath));
entityConfigurationCreator.Create(new CreateEntityConfigurationOptions(entityOptions, configurationFolderPath));

var x = new EntityOptions
{
    Name = "Test2",
    Namespace = "TestClient.Entities",
    IsTable = true,
    SchemaName = "dbo",
    TableOrViewName = "TEST2",
    Properties = new List<PropertyOptions>
    {
        new("Id", "ID", "int", true, true, 0, 0, 0, false)
    },
    OneToOneRelationships = new List<OneToOneRelationship>
    {
        new("Test2", "Test", "TestId", DeleteBehavior.NoAction)
    }
};
entityCreator.Create(new CreateEntityOptions(x, entitiesFolderPath));