using System.Xml.XPath;
using System.Xml.Linq;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Wiedpug.API.SchemaFilter.SwaggerOptions;
using Wiedpug.API.SchemaFilter;
using Wiedpug.Domain.Attributes;

public class AllOfSchemaForReferencedFieldSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        foreach (var property in schema.Properties.ToList())
        {
            if (property.Value.Reference != null)
            {
                var reference = property.Value.Reference;
                var description = property.Value.Description;

                if (description != null)
                {

                    // Create a new schema using allOf with the $ref and the description
                    var allOfSchema = new OpenApiSchema
                    {
                        AllOf = new[]
                        {
                        new OpenApiSchema { Reference = reference },
                        new OpenApiSchema { Description = description }
                        }
                    };
                    // Replace the original property with the new allOf schema
                    schema.Properties[property.Key] = allOfSchema;

                } else
                {
                    // Create a new schema using allOf with the $ref and the description
                    var allOfSchema = new OpenApiSchema
                    {
                        AllOf = new[]
                        {
                        new OpenApiSchema { Reference = reference },
                        }
                    };
                    // Replace the original property with the new allOf schema
                    schema.Properties[property.Key] = allOfSchema;
                }
            }
        }
    }
}



