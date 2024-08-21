using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LengthAndStrengthTestDetailType

    {
        [Description("L: Length And Strength Test Detail")]
        L,

        [Description("K: Length And Strength Combination Test Detail")]
        K

    }
}
