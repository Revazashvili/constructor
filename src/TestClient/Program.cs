// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Constructor.Core.Models;
using Constructor.Core.Templates;

Console.WriteLine("Hello, World!");
var entityOptions = new EntityOptions
{
    Name = "Test",
    Namespace = "TestClient.Entities",
    IsTable = true,
    Properties = new List<PropertyOptions>
    {
        new()
        {
            Name = "Id",
            Type = "int",
            ColumnName = "ID",
            IsRequired = true,
            IsPrimaryKey = true
        },
        new()
        {
            Name = "FirstName",
            Type = "string",
            ColumnName = "FIRSTNAME",
            IsRequired = true,
            MaxLength = 20,
            IsPrimaryKey = false
        },
        new()
        {
            Name = "LastName",
            Type = "string",
            ColumnName = "LASTNAME",
            IsRequired = true,
            MaxLength = 20,
            IsPrimaryKey = false
        },
    }
};
var entity = new Entity
{
    EntityOptions = entityOptions
};

var entitiesFolderPath = @"C:\Projects\NetCore\constructor\src\TestClient\Entities";
var filePath = $@"{entitiesFolderPath}\{entityOptions.Name}.cs";
var fileContent = entity.TransformText();
var file = new FileInfo(filePath);
file.Directory?.Create();
File.WriteAllText(filePath, fileContent);
