using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ColourTestDetailsType

    {
        [Description("C: Colour Test Details")]
        C,

        [Description("X: Colour Combination Test Details")]
        X

    }
}
