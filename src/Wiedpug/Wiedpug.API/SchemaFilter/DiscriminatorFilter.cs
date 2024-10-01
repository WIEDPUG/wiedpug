using System.Xml.XPath;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Interface;

public class DiscriminatorFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        // operations on Centre oneOf relationships
        if (context.Type == typeof(Centre))
        {
            schema.Properties["centreCode"] = new OpenApiSchema
            {
                AnyOf = new List<OpenApiSchema>
                {
                    new OpenApiSchema { Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = "CentreCodeAustralia" } },
                    new OpenApiSchema { Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = "CentreCodeChina" } },
                    new OpenApiSchema { Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = "CentreCodeGermany" } },
                    new OpenApiSchema { Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = "CentreCodeItaly" } },
                    new OpenApiSchema { Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = "CentreCodeNewZealand" } },
                    new OpenApiSchema { Reference = new OpenApiReference { Type = ReferenceType.Schema, Id = "CentreCodeTaiwan" } }
                }
            };

            schema.Discriminator = new OpenApiDiscriminator
            {
                PropertyName = "countryCode",
                Mapping = new Dictionary<string, string>
                {
                        { "AU", "#/components/schemas/CentreCodeAustralia" },
                        { "CN", "#/components/schemas/CentreCodeChina" },
                        { "DE", "#/components/schemas/CentreCodeGermany" },
                        { "IT", "#/components/schemas/CentreCodeItaly" },
                        { "NZ", "#/components/schemas/CentreCodeNewZealand" },
                        { "TW", "#/components/schemas/CentreCodeTaiwan" }
                }
            };

            // remove unnecessary properties that are used for link reference only
            var propertiesToRemove = new[]
            {
                "centreAustralia",
                "centreChina",
                "centreGermany",
                "centreItaly",
                "centreNewZealand",
                "centreTaiwan"
            };

            foreach (var property in propertiesToRemove)
            {
                if (schema.Properties.ContainsKey(property))
                {
                    schema.Properties.Remove(property);
                }
            }
        }

        // operations on IRequestForDataType oneOf relationships
        if (context.Type == typeof(RequestForData))
        {
            schema.Discriminator = new OpenApiDiscriminator
            {
                PropertyName = "requestForDataType",
                Mapping = new Dictionary<string, string>
                {
                        { "UseNetworkDateTimeRequestForDataType", "#/components/schemas/UseNetworkDateTimeRequestForDataType" },
                        { "DateTimeRangeRequestForDataType", "#/components/schemas/DateTimeRangeRequestForDataType" }
                }
            };

            // remove unnecessary properties that are used for link reference only
            var propertiesToRemove = new[]
            {
                "useNetworkDateTimeRequestForDataType",
                "dateTimeRangeRequestForDataType",
            };

            foreach (var property in propertiesToRemove)
            {
                if (schema.Properties.ContainsKey(property))
                {
                    schema.Properties.Remove(property);
                }
            }
        }

        // operations on EncryptedLotHeaderAwexData oneOf relationships
        if (context.Type == typeof(EncryptedLotHeaderAwexData))
        {

            // remove unnecessary properties that are used for link reference only
            var propertiesToRemove = new[]
            {
                "lotHeaderAwexData",
            };

            foreach (var property in propertiesToRemove)
            {
                if (schema.Properties.ContainsKey(property))
                {
                    schema.Properties.Remove(property);
                }
            }
        }

    }
}
