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

public class SharedReferencedFieldSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (context.Type == typeof(UtcDate))
        {
            // Clear any old schema properties, if necessary
            schema.Properties?.Clear();
            schema.AllOf?.Clear();
            schema.OneOf?.Clear();
            schema.AnyOf?.Clear();
            schema.Required.Clear();
            schema.AdditionalPropertiesAllowed = false;

            schema.Type = "string";  // Represent UtcDate as a string in OpenAPI
            schema.Format = RegexPattern.DATE_UTC_ISO8601;  // Specify ISO 8601 UTC date format
            schema.Description = "Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD).";
            schema.Example = new OpenApiString("2024-03-21");
        }

        if (context.Type == typeof(UtcDateTime))
        {
            // Clear any old schema properties, if necessary
            schema.Properties?.Clear();
            schema.AllOf?.Clear();
            schema.OneOf?.Clear();
            schema.AnyOf?.Clear();
            schema.AdditionalPropertiesAllowed = false;

            schema.Type = "string";  // Represent UtcDate as a string in OpenAPI
            schema.Format = RegexPattern.DATE_AND_TIME_UTC_ISO8601;  // Specify ISO 8601 UTC date format
            schema.Description = "Date and Time value in ISO 8601 standard UTC datetime format. e.g. 2024-03-21T19:25:04+00:00.000Z";
            schema.Example = new OpenApiString("2024-03-21T19:25:04+00:00.000Z");
        }

        if (context.Type == typeof(LotIdentity))
        {
            // Clear any old schema properties, if necessary
            schema.Properties?.Clear();
            schema.AllOf?.Clear();
            schema.OneOf?.Clear();
            schema.AnyOf?.Clear();
            schema.AdditionalPropertiesAllowed = false;

            schema.Type = "string";
            schema.MaxLength = 6;
            schema.MinLength = 0;
            schema.Description = "This is a compound name for lot number and lot suffix, where the lot \r\nnumber is 5 numeric characters and the lot suffix is 1 alphanumeric\r\ncharacter.The suffix is used when a lot is broken up by the original lot\r\nnumber is retained; for example.If 2 bales of a 10-bale lot got wet and\r\nthe 8 bales and the 2 bales are offered separately, one could have a\r\nsuffix A and the other a suffix B.Where a suffix is not used, the lot\r\nnumber occupies the whole of the Lot Identity field and is right justified.\r\n            \r\nFrom:\r\n            \r\nThe current value that the Lot Identity is to be changed from.\r\n\r\nTo:\r\n\r\nThe new value that the Lot Identity is to be changed to.";
        }

        if (context.Type == typeof(NumberOfBales)) 
        {
            // Clear any old schema properties, if necessary
            schema.Properties?.Clear();
            schema.AllOf?.Clear();
            schema.OneOf?.Clear();
            schema.AnyOf?.Clear();
            schema.AdditionalPropertiesAllowed = false;

            schema.Type = "integer";  // Represent UtcDate as a string in OpenAPI
            schema.Format = "int32";  // Specify ISO 8601 UTC date format
            schema.Minimum = -9999;
            schema.Maximum = 9999;
        }

        if (context.Type == typeof(Season))
        {
            // Clear any old schema properties, if necessary
            schema.Properties?.Clear();
            schema.AllOf?.Clear();
            schema.OneOf?.Clear();
            schema.AnyOf?.Clear();
            schema.AdditionalPropertiesAllowed = false;

            schema.Type = "integer";  // Represent UtcDate as a string in OpenAPI
            schema.Format = "int32";  // Specify ISO 8601 UTC date format
            schema.Minimum = -99;
            schema.Maximum = 99;
        }
    }
}



