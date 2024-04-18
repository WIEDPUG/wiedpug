using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.API.SchemaFilter
{
    /// <summary>
    /// Manipulate schema values (e.g. enum) so it can be displayed properly in the UI
    /// </summary>
    public class ManipulateEnumForOpenApiSpec : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.Type.IsEnum)
            {
                schema.Description = GetEnumTypeDescription(context.Type);
                
                var removeUnderscorePrefix = context.Type.GetCustomAttributes(false).OfType<RemoveUnderscoreFromEnumItemAttribute>().Any();
                if (removeUnderscorePrefix)
                    RemoveEnumItemUnderscorePrefix(schema, context);

            }
        }

        /// <summary>
        /// Manipulate the enum value to remove the underscore prefix from the enum item if exist.
        /// The underscore prefix has been added as a workaround for enums that contain items that starts with a number.
        /// In C#, an enum item cannot start with a number.
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="context"></param>
        public static void RemoveEnumItemUnderscorePrefix(OpenApiSchema schema, SchemaFilterContext context)
        {
            schema.Enum.Clear();
            foreach (var enumName in context.Type.GetEnumNames())
            {
                schema.Enum.Add(new OpenApiString(enumName.Replace("_", string.Empty)));
            }
        }

        /// <summary>
        /// Gets the value from the [Description] annotation assigned to each enum item and append to the schema Description.
        /// This is so enum value can be clearly described in the UI. e.g. "0: Standard (farm) bale"
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetEnumTypeDescription(Type type)
        {
            var descriptions = type.GetCustomAttributes(false).OfType<DescriptionAttribute>().Select(d => d.Description).ToList();
            foreach (var enumValue in type.GetEnumValues())
            {
                descriptions.AddRange(type.GetMember(enumValue.ToString()).SelectMany(t => t.GetCustomAttributes(false)).OfType<DescriptionAttribute>().Select(d => d.Description));
            }
            if (descriptions.Any())
            {
                return string.Join("<br />", descriptions);
            }
            return null;

        }
    }

}
