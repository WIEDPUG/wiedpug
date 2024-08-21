using Swashbuckle.AspNetCore.Filters;
using System.Reflection;
using Asp.Versioning;
using Asp.Versioning.ApiExplorer;
using Wiedpug.API.Controllers.V0;
//using Wiedpug.API.Controllers.V1;
using Wiedpug.API.Controllers.V2;
using Wiedpug.API.SchemaFilter.SwaggerOptions;
using Microsoft.Extensions.DependencyInjection;
using Wiedpug.Domain.Entities;
using Microsoft.OpenApi.Models;
using Wiedpug.Domain.Interface;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
    });
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

    c.SchemaFilter<IncludeRequestForDataTypesForOpenApiSpec>();

    c.ExampleFilters();

    // Polymorphism handling for RequestForDataType - convert to the OneOf relationships for the RequestForDataType classes
    c.MapType<IRequestForDataType>(() => new OpenApiSchema
    {
        OneOf = new List<OpenApiSchema>
        {
            new OpenApiSchema { Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = nameof(UseNetworkDateTimeRequestForDataType) } },
            new OpenApiSchema { Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = nameof(DateTimeRangeRequestForDataType) } }
        }
    });
});




   builder.Services.AddSwaggerExamplesFromAssemblyOf<Program>();

var app = builder.Build();

var apiVersionSet = app.NewApiVersionSet()
                //.HasApiVersion(new ApiVersion(1, "Deprecated")) //Adding a Status of "Deprecated" to mark the version as Deprecated
            .HasApiVersion(new ApiVersion(0, 0))
            .HasApiVersion(new ApiVersion(1,0))
            .HasApiVersion(new ApiVersion(2,0))            
            .ReportApiVersions()            
            .Build();
var versionedGroup = app.MapGroup("v{version:apiVersion}").WithApiVersionSet(apiVersionSet);


versionedGroup.MapTestCertificatesEndpoints();

versionedGroup.MapTestCertificateUpdateEndpoints();

versionedGroup.MapTestCertificateRequestsEndpoints();

versionedGroup.MapCatalogueEndpoints();

versionedGroup.MapOrganisationDetailsEndpoints();

versionedGroup.MapTestStatusEndpoints();

versionedGroup.MapTestRequestsVerificationEndpoints();

versionedGroup.MapLotInvoicesEndpoints();

versionedGroup.MapDarkAndMedullatedFibreRiskVerificationEndpoints();

versionedGroup.MapPaymentAdvicesEndpoints();

versionedGroup.MapPaymentConfirmationEndpoints();

versionedGroup.MapDeliveryOrderAndShippingInstructionsEndpoints();

versionedGroup.MapRequestPostsalePrintingOfPresaleCertificatesEndpoints();

versionedGroup.MapStatementsEndpoints();

versionedGroup.MapTextsEndpoints();

versionedGroup.MapLotPriceAndBuyerEndpoints();

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
