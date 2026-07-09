# TheBootstrapTheme for Orchard Core

Orchard Core theme with Bootstrap

## Status

[![AppVeyor](https://ci.appveyor.com/api/projects/status/q7bp4op2gslfa4e6?svg=true)](https://ci.appveyor.com/project/agriffard/thebootstraptheme)
[![NuGet](https://img.shields.io/nuget/v/TheBootstrapTheme.OrchardCore.svg)](https://www.nuget.org/packages/TheBootstrapTheme)

## Getting Started

- Add the nuget package TheBootstrapTheme.OrchardCore as a reference to your application using Orchard Core Cms Target.
- Create a site using the Bootstrap recipe.

## Sample

The `src/TheBootstrapTheme.Samples.Web` project is a sample Orchard Core CMS application that uses [AutoSetup](https://docs.orchardcore.net/en/latest/reference/modules/AutoSetup/) to set up a site with the Bootstrap recipe on first launch:

```bash
dotnet run --project src/TheBootstrapTheme.Samples.Web
```

The site is created automatically (SQLite database, admin user `admin` / `Password1!`, see `appsettings.json`). Delete the `App_Data` folder to reset it.
