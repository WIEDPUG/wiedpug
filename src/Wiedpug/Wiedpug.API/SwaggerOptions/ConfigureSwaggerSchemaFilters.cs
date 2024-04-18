using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Wiedpug.API.SchemaFilter;

namespace Wiedpug.API.SwaggerOptions
{
    public class ConfigureSwaggerSchemaFilters : IConfigureNamedOptions<SwaggerGenOptions>
    {    
        public void Configure(string? name, SwaggerGenOptions options)
        {
            Configure(options);
        }

        public void Configure(SwaggerGenOptions options)
        {
            options.SchemaFilter<ManipulateEnumForOpenApiSpec>();
        }
    }
}
