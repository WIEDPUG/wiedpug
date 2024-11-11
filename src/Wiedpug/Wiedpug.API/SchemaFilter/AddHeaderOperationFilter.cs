using System.Xml.XPath;
using System.Xml.Linq;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Wiedpug.API.SchemaFilter.SwaggerOptions;
using Wiedpug.API.SchemaFilter;
using Wiedpug.Domain.Attributes;
using Wiedpug.Domain.ValueObject;
using Wiedpug.Domain.Shared.Constants;
using Microsoft.OpenApi.Any;
using System;

public class AddHeaderOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        operation.Parameters.Add(new OpenApiParameter
        {
            Name = "api-version",
            In = ParameterLocation.Header,
            Required = false,
            Description = "Specify the version of the API",
            Schema = new OpenApiSchema
            {
                Type = "string",
                Example = new OpenApiString("1.0.0")
            }
        });
    }
}


