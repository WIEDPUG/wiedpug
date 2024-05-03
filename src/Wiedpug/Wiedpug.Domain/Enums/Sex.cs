using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Sex
    {
        [Description("Ewes: Code: E. Ewes")]
        Ewes,

        [Description("Wethers: Code: W. Wethers")]
        Wethers,

        [Description("Rams: Code: R. Rams")]
        Rams,

        [Description("Mixed: Code: M. Mixed")]
        Mixed
    }
}
