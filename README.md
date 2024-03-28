### About the project

This project serves as a central place to host all deliverables for WIEDPUG Phase 2 project.

It includes the class diagram, security model, sequence diagram, and openApi specs.


#### Run the project

Install dependencies:
```
npm install
```

Local development:
```
npm run dev
```


##### TODO: setup config to deploy static webapp to gh-pages


### Wiedpug Web API developer setup

Wiedpug.API is a ASP.Net Web API project using .NET 8.0.
It is used for the following reasons:
- Define Open API specifications (e.g. Response Codes, Examples, etc.)
- Rendering of Open API specification using Swagger UI during development for verifying changes made
- Generate Swagger YAML and JSON files under `wwwroot` folder

**File System Location**: src\Wiedpug\ folder
**Solution Name**: `Wiedpug.sln`
**Projects under solution**:
- Wiedpug.API - Start up project
- Wiedpug.Domain - Class Library project

## Requirements
- Visual Studio (2022)
  - Visual Studio Code can be used as well
- .NET 8.0 SDK
  - Projects are using .NET 8
- Swashbuckle.AspNetCore.Cli (dotnet tool)
	- This is need in order to automatically generate Swagger YAML and JSON files everytime the projects are built. The generated files are generated in `wwwroot\swagger\v1` folder
	- At the time of writing, the latest version only supports .NET 7.0, therefore .NET 7.0 SDK is also required.
	- Installation:
	  Reference: [Swashbuckle.AspNetCore.Cli - Using dotnet tools](https://github.com/domaindrivendev/Swashbuckle.AspNetCore?tab=readme-ov-file#using-the-tool-with-the-net-core-30-sdk-or-later)
		- Run this command if there is no `.config\dotnet-tools.json` under `Wiedpug.API` folder: `dotnet new tool-manifest`
		- Run this command in terminal: `dotnet tool install -g Swashbuckle.AspNetCore.Cli`

