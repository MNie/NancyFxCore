[![NuGet Badge](https://buildstats.info/nuget/NancyFx.Core.Template)](https://www.nuget.org/packages/NancyFx.Core.Template)
[![Build Status](https://travis-ci.org/MNie/NancyFxCore.svg?branch=master)](https://travis-ci.org/MNie/NancyFxCore)

# F# ASP.NET Core NancyFx Template
# How to use it?
* fork and download repository
* install template as a .net core template from nuget
* install template as a .net core template locally

# How to install it as a template from nuget?
* run `dotnet new -i NancyFx.Core.Template::*`
* create new project executing `dotnet new nancyfx -n PROJECT_NAME -o FOLDER_NAME`

# How to install it as a template locally?
* download repository
* run command `dotnet new -i PATH*`, where *PATH* is a path to a folder where project is located
* create new project executing `dotnet new nancyfx -n PROJECT_NAME -o FOLDER_NAME`
* `dotnet restore`
* `dotnet run` or `dotnet watch run`

If you want to extend this template, or create more complex one based on this, don't hold back :)
