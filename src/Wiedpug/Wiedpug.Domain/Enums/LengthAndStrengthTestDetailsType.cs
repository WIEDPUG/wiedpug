using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LengthAndStrengthTestDetailsType

    {
        [Description("L: Length And Strength Test Details")]
        L,

        [Description("K: Length And Strength Combination Test Details")]
        K

    }
}
