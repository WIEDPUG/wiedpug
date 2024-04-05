using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BaleDetailType
    {
        [Description("Renumbers: Bale Details - Renumbers")]
        Renumbers,

        [Description("GreasyOrProcessed: Bale Details - GreasyOrProcessed")]
        GreasyOrProcessed,

        [Description("Tripacks: Bale Details - Tripacks")]
        Tripacks,
    }
}
