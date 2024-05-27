using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TransferType
    {
        [Description("Broadcast: Send document to all members")]
        Broadcast,

        [Description("PrivateSend: Send document to appointed members")]
        PrivateSend,

    }
}
