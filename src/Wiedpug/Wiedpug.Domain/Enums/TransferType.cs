using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TransferType
    {
        [Description("Unrestrict: Send document to all members")]
        Unrestrict,

        [Description("Restrict: Send document to appointed members")]
        Restrict,

        [Description("Exclude: Send to all members excluding the appointed members")]
        Exclude,

    }
}
