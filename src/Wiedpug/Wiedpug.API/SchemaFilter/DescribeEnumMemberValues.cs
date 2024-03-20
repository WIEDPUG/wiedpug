using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Wiedpug.API.SchemaFilter
{
    public class DescribeEnumMemberValues : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.Type.IsEnum)
            {                
                schema.Description = GetEnumTypeDescription(context.Type);
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
