using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AutoAdditionalMeasurementRequired
    {
        [Description("N: Automatic combinations not required")]
        N,

        [Description("L: Automatic Length & Strength Combination required")]
        L,

        [Description("C: Automatic Colour Combination is required")]
        C,

        [Description("B: Both Length & Strength and Colour combinations required")]
        B
    }
}
