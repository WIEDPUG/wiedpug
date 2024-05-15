using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum DeclaredQualifierScale
    {
        [Description("0: No scale/qualifier code is T")]
        NoTScaleOrQualifierCode = 0,

        [Description("1: Light/Odd")]
        LightOrOdd = 1,

        [Description("2: Medium")]
        Medium = 2,

        [Description("3: Heavy/Line of…")]
        HeaveyOrLine = 3
    }
}
