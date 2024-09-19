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
using System.Globalization;

public class DoubleFieldSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (context.Type == typeof(double))
        {
            Console.WriteLine($"get One dobule, {context}!");
            // Check if the Minimum value exists and is valid
            if (schema.Maximum.HasValue)
            {
                // Convert the Minimum value to a string using invariant culture
                string strValue = schema.Maximum.Value.ToString(CultureInfo.InvariantCulture);

                // Split the number into integer and decimal parts
                string[] parts = strValue.Split('.');
                int decimalDigits = parts.Length > 1 ? parts[1].Length : 0; // Handle cases with no decimal part

                // Calculate the appropriate multipleOf value
                if (decimalDigits > 0)
                {
                    schema.MultipleOf = (decimal?)Math.Pow(10, -decimalDigits);
                }
                else
                {
                    schema.MultipleOf = 1; // No decimal places means multipleOf is 1
                }
            }
        }
    }
}



