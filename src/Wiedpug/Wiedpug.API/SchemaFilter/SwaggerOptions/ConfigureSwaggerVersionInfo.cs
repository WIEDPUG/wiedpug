using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Wiedpug.API.SchemaFilter.SwaggerOptions
{
    /// <summary>
    /// Contains the configuration required to generate JSON documentation for all versions of API. 
    /// This class uses the default IApiVersionDescriptionProvider service of Asp.Versioning.ApiExplorer library to gather information 
    /// about all the API versions that exist and dynamically configure Swagger documentation for each of them.
    /// </summary>
    public class ConfigureSwaggerVersionInfo : IConfigureNamedOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider provider;
        public ConfigureSwaggerVersionInfo(IApiVersionDescriptionProvider provider)
        {
            this.provider = provider;
        }

        public void Configure(string? name, SwaggerGenOptions options)
        {
            Configure(options);
        }

        public void Configure(SwaggerGenOptions options)
        {

            // add swagger document for every API version discovered
            foreach (var description in provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(
                    description.GroupName,
                    CreateVersionInfo(description));
            }
        }

        private OpenApiInfo CreateVersionInfo(
                ApiVersionDescription description)
        {
            var info = new OpenApiInfo()
            {
                Title = $"WIEDPUG API",
                Version = description.GroupName.ToString(),
                Description = "API Documentation for the WIEDPUG Network",
                TermsOfService = new Uri("https://wiedpug.github.io/wiedpug"),
                Contact = new OpenApiContact
                {
                    Email = "changethis@email.com",
                    Name = "WIEDPUG Team",
                    Url = new Uri("https://wiedpug.github.io/wiedpug")
                },
                License = new OpenApiLicense
                {
                    Name = "Applicable License",
                    Url = new Uri("https://wiedpug.github.io/wiedpug")
                }
            };
            if (description.IsDeprecated)
            {
                info.Description += " This API version has been deprecated.";
            }
            return info;
        }
    }

}
