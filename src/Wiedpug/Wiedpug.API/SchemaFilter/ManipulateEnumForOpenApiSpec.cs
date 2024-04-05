using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.API.SchemaFilter
{
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


                //schema.Enum.Clear();

                ////Retrieve each of the values decorated with an EnumMember attribute
                //foreach (var member in context.Type.GetMembers())
                //{
                //    var memberAttr = member.GetCustomAttributes(typeof(EnumMemberAttribute), false).FirstOrDefault();
                //    if (memberAttr != null)
                //    {
                //        var attr = (EnumMemberAttribute)memberAttr;
                //        schema.Enum.Add(new OpenApiString(attr.Value));
                //    }
                //}
            }
        }

        public static void RemoveEnumItemUnderscorePrefix(OpenApiSchema schema, SchemaFilterContext context)
        {
            schema.Enum.Clear();
            foreach (var enumName in context.Type.GetEnumNames())
            {
                schema.Enum.Add(new OpenApiString(enumName.Replace("_", string.Empty)));
            }
        }

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
