using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using Wiedpug.Domain.Entities;

public class IncludeRequestForDataTypesForOpenApiSpec : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        // Check if this is the schema you want to add
        if (context.Type == typeof(UseNetworkDateTimeRequestForDataType))
        {

        }

        if (context.Type == typeof(DateTimeRangeRequestForDataType))
        {

        }

        if (context.Type == typeof(WoolSaleRequestForDataType))
        {

        }
    }
}
