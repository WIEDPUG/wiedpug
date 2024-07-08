using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ElectronicSaleFlag

    {
        [Description("Y: Yes")]
        Y,

        [Description("N: No")]
        N

    }
}
