using System;
using System.Collections.Generic;
using Constructor.Core;
using Constructor.Core.Creators;
using Constructor.Core.Models;
using Constructor.Core.Providers;
using Microsoft.EntityFrameworkCore;

const string entitiesFolderPath = @"C:\Projects\NetCore\constructor\src\TestClient\Entities";
const string configurationFolderPath = @"C:\Projects\NetCore\constructor\src\TestClient\Configurations";
Console.WriteLine("Start building...");
var entityOptionsProvider = new EntityOptionsProvider();
var entityOptions = entityOptionsProvider.Provide();
var entityCreator = CreatorProvider.GetEntityCreator();
var entityConfigurationCreator = CreatorProvider.GetEntityConfigurationCreator();

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