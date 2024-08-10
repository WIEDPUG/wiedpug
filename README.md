[[_TOC_]]

# About the project

This project serves as a central place to host all deliverables for WIEDPUG Phase 2 project.

It includes the class diagram, security model, sequence diagram, and openApi specs.


# Nextra Site

Nextra is the static webpage that is used to display our deliverables for Phase 2.

Nextra is located in the root folder of this repository.
- `pages` folder - Contains Nextra pages.
- `public` folder - Contains files that are rendered by the Nextra Site.
- `.next` folder - The generated folder after running `npm run dev`

### Setup
Install dependencies:
```
npm install
```

Local development:

In the next.config.js file, comment out the following two lines:
```
  output: "export",
  basePath: "/wiedpug"
```
(For pushing to GitHub, please uncomment these two lines. They will be required to build the GitHub Page.)

Then run the command:
```
npm run dev
```

Access the page in the browser:
- Go to http://localhost:3000/wiedpug


# Wiedpug Web API Swagger Documentation

`Wiedpug.API` is a ASP.Net Core Web API project using .NET 8.0.
It is used for the following reasons:
- Define Open API specifications (e.g. endpoints, payloads, responses, examples, etc.)
- Render of Open API specification using Swagger UI during development for verifying changes made
- Easy maintenance of documentation
- Generate Swagger JSON and YAML files
- Generate Class Diagram

### Project Info
- **File System Location**: src\Wiedpug\ folder
- **Solution Name**: `Wiedpug.sln`
- **Projects under solution**:
  - `Wiedpug.API` - Start up project taht renders the Swagger documentation
  - `Wiedpug.Domain` - Class Library project

### Requirements
- Visual Studio (2022)
  - Visual Studio Code can be used as well
- .NET 8.0 SDK
  - Projects are using .NET 8

## Swagger Documentation

### Basic API Information Setup
- Basic information about the API needs to be defined as part of the Documentation.
- Placeholders have been configured which needs to be replaced with real details.
- The information can be modified in `Wiedpug.API` > `SwaggerOptions` > `ConfigureSwaggerVersionInfo.cs`
   - Locate the `CreateVersionInfo` method
   - Update the details with correct values

### Folder and Model Structure
- All models are defined in `Wiedpug.Domain` project
- It follows the Domain-Driven Design file structure which makes use of the following
   - `Aggregates` folder
      - Contains classes which translates to `Document Types` in Wiedpug Handbook (e.g. Organization Details, Auction Catalogue)	        
	  - These classes holds a number of entities.
   - `Entities` folder
      - Contains classes which translates to `Record Type` in Wiedpug Handbook
	  - These classes are used by the Aggregate class
   - `ValueObject` folder
      - These are classes that represents a specific value e.g. Address, Contact
	  - These classes are used within Entities

### Other Folder Definition
 - `Attributes` folder
    - Contains custom attributes
- `Enums` folder
    - Contains enums that are used to define the possible values for the property.

### Creating a new Model Class
- Models are located in `Wiedpug.Domain` project
- Start by creating a new folder under `Aggregates` folder e.g. AuctionCatalogueAggregate.
   - Inside, create a new class which will serve as the root class for your model.
- Create all related entities in `Entities` folder then reference the entities in your root class.
   - In your entity class, you can reference a Value Object class or an enum in addition to the standard types.
- You can create an enum to define the possible values for the class property.

### Documenting a Model Class
- To describe a model or its properties, use the XML comments by adding it above the Class or property declaration.
- To define restrictions, use the built-in data annotation attributes available in .net `System.ComponentModel.DataAnnotations`
   - Some of the common data annotation attributes that we use are:
   - `[Required]`, `[DataType]`, `[RegularExpression]`, `[MaxLength]`, `[Range]`
- To define a property as required field, add a `[Required]` attribute and also a `required` flag before the data type. e.g. `public required double Property3 { get; set; }`
- To define a property as `nullable`, add `?` after the data type. e.g. `public double? Property3 { get; set; } `

Example:
```
/// <summary>
/// Description of Colour Details here..
/// </summary>
public class ColourDetails
{
    /// <summary>
    /// A required string...
    /// </summary>
	[Required]    
    public required string Property1 { get; set; } 

    /// <summary>
    /// A nullable string...
    /// </summary>    
    public string? Property2 { get; set; } 

    /// <summary>
    /// A required property with 2 decimal points...
    /// </summary>
    [Required]
	[RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
    public double Property3 { get; set; } 
}
```


### All about documenting an Enum
- Creating a new enum is straight forward, however it is important to understand how you can add documentation to it.

#### Display Enum with its numeric value
- This is the default behaviour for enums.
- Use this if the expected values of a property are all composed of numeric values

Example:
```
public enum RetestFlag
{    
    NormalTest = 0,    
    Retest = 1,    
    CheckTest = 2
}

// Result: [0, 1, 2] as integer data type
```

#### Display Enum Item names as actual values
- If you intend to display enum item names as literal values, you need to add `[JsonConverter(typeof(JsonStringEnumConverter))]` attribute to the enum declaration.
- This attribute will result in a `string` data type
- This comes in handy when the expected values of a property is a string

Example:   
```
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BaleDetailType
{    
    Renumbers,
    GreasyOrProcessed,
    Tripacks,
}

// Result: [Renumbers, GreasyOrProcessed, GreasyOrProcessed] as string data type
```

#### Display Enum items with some or all of its expected values starts with a number
- In C#, an enum item name should start with a letter. Numbers are not allowed as the first character for an enum item.
- To workaround this issue, 
   - Add `[JsonConverter(typeof(JsonStringEnumConverter))]` attribute to the enum declaration   
   - Add `[RemoveUnderscoreFromEnumItem]` attribute to the enum declaration   
   - A numeric value should be prefixed with an underscore to the enum item

Example:
```
[JsonConverter(typeof(JsonStringEnumConverter))]
[RemoveUnderscoreFromEnumItem]    
public enum DarkAndMedullatedFibreRisk
{    
    E,           
    D,    
    _1,
    _2,    
}

// Result: [E, D, 1, 2] as string data type
```

#### Describing an enum and its values
- Enums are reusable, therefore, adding description in an enum is beneficial to avoid duplicating description.
- We can describe an enum and its values by adding a `[Description]` attribute.
- When there are documentation inside enum, you won't have to add documentation to the property that's referencing the enum.
- **Important:** Adding a documentation to the property referencing an enum will suppress the documentation inside enum.

Example 1:
```
[Description("The code for a Test House.")]
public enum Laboratory
{
    [Description("1: Australian Wool Testing Authority")]
    AustralianWoolTestingAuthority = 1,

    [Description("2: N.Z. Wool Testing Authority")]
    NZWoolTestingAuthority = 2,

    [Description("3: N.Z. Wool Testing Service")]
    NZWoolTestingService = 3,

    [Description("4: South African Wool Testing Authority")]
    SouthAfricanWoolTestingAuthority = 4
}
```

Example 2:
```
[Description("A flag to indicate what type of change has been made to an item.")]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UpdateType
{
    [Description("A: The entry is to be added")]
    A,

    [Description("C: The entry is to be changed")]
    C,

    [Description("D: The entry is to be deleted")]
    D
}
```

### Creating Class Diagram
- Class Diagrams are created per Document Type.
- To create a class diagram,
   - Right click on `Wieldpug.Domain` project > `Add` > `New Item`
   - Select `Class Diagram` in the template list
   - Set the file name e.g. organization-details-class-diagram.cd
- To add related entities, first, drag and drop the root class (e.g. OrganizationDetails.cs) from solution explorer to the Class Diagram window
- To add sub-models
   - for property with Class reference, right click on the property then select `Show as Association`.
   - for property with Collection reference, right click on the property then select `Show as Collection Association`.
   - Repeat the steps above until all related models are added into the Class Diagram.
- To generate the Class Diagram image, right click on any empty spot inside the Class Diagram then select `Export Diagram as Image...`
   - Set the filename
   - Set the file type to `JPG`
- Once image has been exported, copy and paste the image to `root directory` > `public` > `class-diagram` folder. Nextra will dynamically create a menu item for the new class diagram image.

### Adding API Endpoint
- API Endpoints are added in `Wiedpug.API` project
- API Endpoints are stored inside `Controllers` folder
- Each Endpoint file relates to a `Document Type`
- To add a new Endpoint, simply duplicate any existing Endpoint file. 
   - If you want to do the long process, inside the `Controllers` folder, right click on the folder e.g. `V1` > `Add` > `Controller`
   - Under `Common` > `API`, select `API with read/write endpoints`
   - Follow the prompts

### Authentication Setup
- This is the documentation of what authentication will be used in the API.
- The documentation is located in `Wiedpug.API` > `SwaggerOptions` > `ConfigureSwaggerSecurity.cs`

### Versioning Setup
- The `Wiedpug.API` project is configured for automatic generation of versions.
- The configuration is located in `Wiedpug.API` > `SwaggerOptions` > `ConfigureSwaggerVersionInfo.cs`
- Some of its configurations are located in `Wiedpug.API` > `Program.cs`

This code snippet in `Program.cs` defines the basic setup for versioning.
```
builder.Services.AddApiVersioning(
	options =>
	{                    
		options.DefaultApiVersion = new ApiVersion(1,0);
		options.AssumeDefaultVersionWhenUnspecified = true;
		options.ApiVersionReader = new UrlSegmentApiVersionReader();
	})
.AddApiExplorer(setup =>
{
	setup.GroupNameFormat = "'v'VV";
	setup.SubstituteApiVersionInUrl = true;
});
```

This code snippet in `Program.cs` configures 2 versions. Versions 1.0 and 2.0. If a new version needs to be added in the future, add `.HasApiVersion(new ApiVersion(MAJOR_VERSION_HERE, MINOR_VERSION_HERE))`
```
var apiVersionSet = app.NewApiVersionSet()	
	.HasApiVersion(new ApiVersion(1,0))
	.HasApiVersion(new ApiVersion(2,0))            
	.ReportApiVersions()            
	.Build();
```

#### Marking Endpoints with a different version
- The project is configured to have version 1.0 as the default. 
- If the endpoint does not have an explicit version assignment, it will be assumed as version 1.0

Example #1: Version 1 of the Auction Catalogue Endpoint.
- The code snippet below shows that all endpoints are mapped to Version 1.0.
- The `.MapToApiVersion(1,0)` is not required to be added because the project is configured to assume version 1.0 as default version when mapping is not specified.
```
namespace Wiedpug.API.Controllers.V1;
public static class AuctionCatalogueEndpoints
{
    public static void MapAuctionCatalogueEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/auction-catalogue")
            //.MapToApiVersion(1,0) //This is optional for Version 1.0
            .WithTags("Auction Catalogue");

        group.MapPost("/",                        
        ([FromBody] List<AuctionCatalogue> model) =>
        {   			         
        })        
        .WithOpenApi();

        group.MapPost("/updates",                        
        ([FromBody] List<AuctionCatalogue> model) =>
        {            
        })        
        .WithOpenApi();
	}
}
```

Example #2: Version 2 of the Auction Catalogue Endpoint
- The code snippet below shows that a controller is mapped to API Version 2.0 using this code `.MapToApiVersion(2,0)`. This means all endpoints in this controller will be mapped to version 2.0.
- It also shows changes to existing endpoints and a new endpoint for version 2.0

```
namespace Wiedpug.API.Controllers.V2;

//Different Class Name for V2
public static class AuctionCatalogueEndpointsV2
{
    public static void MapAuctionCatalogueEndpointsV2(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/auction-catalogue")
            .MapToApiVersion(2,0)
            .WithTags("Auction Catalogue");

        group.MapPost("/",                        
        ([FromBody] List<AuctionCatalogueV2> model) =>
        { 
			// This endpoint has updated data type AuctionCatalogueV2.           
        })        
        .WithOpenApi();

        group.MapPost("/updates",                        
        ([FromBody] List<AuctionCatalogue> model) =>
        {     
			//Nothing changed to this endpoint.
        })        
        .WithOpenApi();

		group.MapPost("/new-endpoint",                        
        ([FromBody] List<AuctionCatalogue> model) =>
        {     
			//A new endpoint.
        })        
        .WithOpenApi();
	}
}
```

### Deprecation Setup
Deprecation can be applied to API Controller and individual endpoints.

Example: 
- This shows how to deprecate the API controller or the specific endpoint only.
```
namespace Wiedpug.API.Controllers.V1;
public static class AuctionCatalogueEndpoints
{
    public static void MapAuctionCatalogueEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/auction-catalogue")            
            .WithTags("Auction Catalogue")
			.WithOpenApi(o => new(o)
             {
                 Deprecated = true, // To deprecate all endpoints in this Controller
             });

        group.MapPost("/",                        
        ([FromBody] List<AuctionCatalogue> model) =>
        {   			         
        })        
        .WithOpenApi(o => new(o)
		{
			Deprecated = true, // To deprecate this specific endpoint only
		});

        group.MapPost("/updates",                        
        ([FromBody] List<AuctionCatalogue> model) =>
        {            
        })        
        .WithOpenApi();
	}
}
```

### Examples Setup
- Examples can be created for both Request and Response payloads.
- You can have multiple examples per endpoint.
- Example Request and Response classes are stored in `Wiedpug.API` > `ExampleResponses` folder.

Example:
```
namespace Wiedpug.API.Controllers.V1;
public static class AuctionCatalogueEndpoints
{
    public static void MapAuctionCatalogueEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/auction-catalogue")            
            .WithTags("Auction Catalogue")			

        group.MapPost("/",                        
			[SwaggerRequestExample(typeof(List<AuctionCatalogue>), typeof(AuctionCatalogueRequestExamples))]
			[SwaggerResponseExample(StatusCodes.Status200OK, typeof(AuctionCatalogueResponse200Example))]
			[SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
			[SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
			[SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoWritePermissionExample))]
			[SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] List<AuctionCatalogue> model) =>
        {   			         
        });

        group.MapPost("/updates",                        
        ([FromBody] List<AuctionCatalogue> model) =>
        {            
        });
	}
}
```

### Downloading of Swagger Files
- Swagger files can be downloaded while `Wiedpug.API` project is running.
- The link for `swagger.json` is displayed in the Swagger UI page.
   - Here are the direct links for version 1.0
   - http://localhost:5216/swagger/v1.0/swagger.json
   - http://localhost:5216/swagger/v1.0/swagger.yaml
- If you need to generate other versions available, simply update the URLs above by replacing the version number.
- The swagger files that gets downloaded during runtime is generated on the spot. These files are not stored anywhere.
- Once downloaded, it needs to be moved to the `root directory` > `public` > `openapi` folder. The Nextra site will then render the `swagger.yaml` file.

#### Gotchas
- Generating Swagger files
   - There is a better way to get the generated swagger files. A dotnet tool `Swashbuckle.AspNetCore.Cli` can be used to generate the files without having to run the application. However, this CLI tool is unable to include the Example Request and Response payloads in the generated swagger files. These examples are important part of deliverables to help understand how data is presented.
   - Because of this, there is no choice but to manually download the Swagger files during application runtime and manually pasting it to the `public` > `openapi` folder.


### Generation of Swagger Files (Not in use - Just here for reference)
- Swashbuckle.AspNetCore.Cli (dotnet tool)
	- This is need in order to automatically generate Swagger YAML and JSON files everytime the projects are built. The files are generated in `public` > `openapi` folder of the git repository
	- At the time of writing, the latest version only supports .NET 7.0, therefore .NET 7.0 SDK is also required.
	- Installation:
	  Reference: [Swashbuckle.AspNetCore.Cli - Using dotnet tools](https://github.com/domaindrivendev/Swashbuckle.AspNetCore?tab=readme-ov-file#using-the-tool-with-the-net-core-30-sdk-or-later)
		- Run this command if there is no `.config\dotnet-tools.json` under `Wiedpug.API` folder: `dotnet new tool-manifest`
		- Run this command in terminal: `dotnet tool install -g Swashbuckle.AspNetCore.Cli`		
	- Build Auto Execution:
	   - Edit `Wiedpug.API.csproj` and add this code inside the `<Project>...</Project>` node:
	```
	<Target Name="OpenAPI" AfterTargets="Build" Condition="'$(Configuration)' == 'Debug'">
		<Exec Command="dotnet swagger tofile --output ../../../public/openapi/swagger.yaml --yaml $(OutputPath)$(AssemblyName).dll v1.0" WorkingDirectory="$(ProjectDir)" />
		<Exec Command="dotnet swagger tofile --output ../../../public/openapi/swagger.json $(OutputPath)$(AssemblyName).dll v1.0" WorkingDirectory="$(ProjectDir)" />
	</Target>
	```	
	- Manual Execution:
	   - Open CMD
	   - Change directory to `Wiedpug.API` folder
	   - Run the command to generate and the save file in `root directory` > `public` > `openapi` folder 

	```
	dotnet swagger tofile --output ../../../public/openapi/swagger.json bin\Debug\net8.0\Wiedpug.API.dll v1.0
	```
