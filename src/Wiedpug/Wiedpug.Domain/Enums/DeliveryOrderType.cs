using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeliveryOrderType
    {
        [Description("L: Local Delivery Order")]
        L,

        [Description("O: Export/Overseas Del.Order")]
        O
    }
}
