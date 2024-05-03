using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeclaredQualifierScale
    {
        [Description("NoTScaleOrQualifierCode: Code: 0. No scale/qualifier code is T")]
        NoTScaleOrQualifierCode = 0,

        [Description("LightOrOdd: Code: 1. Light/Odd")]
        LightOrOdd = 1,

        [Description("Medium: Code: 2. Medium")]
        Medium = 2,

        [Description("HeavyOrLine: Code: 3. Heavy/Line of…")]
        HeaveyOrLine = 3
    }
}
