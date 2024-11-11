using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [Description("Note: A “Y” or space in this field will default to “S” when transmitting to AWTA Ltd.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LaserscanTestRequired
    {
        [Description("N: Laserscan Test is not required")]
        N,

        [Description("S: Standard Laserscan Test is required")]
        S,

        [Description("P: Premium Laserscan Test is required")]
        P
    }
}
