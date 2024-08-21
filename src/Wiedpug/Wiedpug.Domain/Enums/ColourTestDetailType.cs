using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ColourTestDetailType

    {
        [Description("C: Colour Test Detail")]
        C,

        [Description("X: Colour Combination Test Detail")]
        X

    }
}
