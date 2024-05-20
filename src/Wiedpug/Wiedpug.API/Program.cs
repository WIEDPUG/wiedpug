using Swashbuckle.AspNetCore.Filters;
using System.Reflection;
using Asp.Versioning;
using Asp.Versioning.ApiExplorer;
using Wiedpug.API.Controllers.V1;
using Wiedpug.API.Controllers.V2;
using Wiedpug.API.SwaggerOptions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
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

builder.Services.ConfigureOptions<ConfigureSwaggerVersionInfo>();
builder.Services.ConfigureOptions<ConfigureSwaggerSchemaFilters>();
builder.Services.ConfigureOptions<ConfigureSwaggerSecurity>();
builder.Services.AddSwaggerGen(c => {    

    //To automatically add XML comments to Open API Spec.
    var apiXmlFilePath = Path.Combine(AppContext.BaseDirectory, "Wiedpug.API.xml");
    c.IncludeXmlComments(apiXmlFilePath);

    var domainXmlFilePath = Path.Combine(AppContext.BaseDirectory, "Wiedpug.Domain.xml");
    c.IncludeXmlComments(domainXmlFilePath);

    //c.ExampleFilters(); //To support examples
    c.ExampleFilters_PrioritizingExplicitlyDefinedExamples();    
});


builder.Services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());

var app = builder.Build();

var apiVersionSet = app.NewApiVersionSet()
                //.HasApiVersion(new ApiVersion(1, "Deprecated")) //Adding a Status of "Deprecated" to mark the version as Deprecated
            .HasApiVersion(new ApiVersion(0, 0))
            .HasApiVersion(new ApiVersion(1,0))
            .HasApiVersion(new ApiVersion(2,0))            
            .ReportApiVersions()            
            .Build();
var versionedGroup = app.MapGroup("v{version:apiVersion}").WithApiVersionSet(apiVersionSet);

//versionedGroup.MapRequestForDataOrStatusEndpoints();

//versionedGroup.MapTestCertificatesEndpoints();

//versionedGroup.MapAuctionCatalogueEndpoints();

//versionedGroup.MapRequestForStatusEndpoints();

versionedGroup.MapOrganizationDetailsEndpoints();

//versionedGroup.MapAuctionCatalogueEndpointsV2();

//versionedGroup.MapTestStatusEndpoints();

//versionedGroup.MapTestCertificateUpdateEndpoints();

//versionedGroup.MapTestCertificateRequestsEndpoints();

//versionedGroup.MapTestRequestsVerificationEndpoints();

//versionedGroup.MapLotInvoicesEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();    

    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {        
        var descriptions = app.DescribeApiVersions();
        foreach (var description in descriptions)
        {            
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                description.GroupName.ToUpperInvariant());
        }
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
