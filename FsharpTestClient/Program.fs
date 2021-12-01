open Constructor.Core.Creators
open Constructor.Core.Providers
open Constructor.Core

let entitiesFolderPath =
    @"C:\Projects\NetCore\constructor\src\TestClient\Entities"

let configurationFolderPath =
    @"C:\Projects\NetCore\constructor\src\TestClient\Configurations"

printfn "Start building..."
let entityOptionsProvider = EntityOptionsProvider()
let entityOptions = entityOptionsProvider.Provide()
let entityCreator = CreatorProvider.GetEntityCreator()

let entityConfigurationCreator =
    CreatorProvider.GetEntityConfigurationCreator()

entityCreator.Create(CreateEntityOptions(entityOptions, entitiesFolderPath))
entityConfigurationCreator.Create(CreateEntityConfigurationOptions(entityOptions, configurationFolderPath))

printfn "Done"
