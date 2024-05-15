using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Sex
    {
        [Description("E: Ewes")]
        E,

        [Description("W: Wethers")]
        W,

        [Description("R: Rams")]
        R,

        [Description("M: Mixed")]
        M
    }
}
