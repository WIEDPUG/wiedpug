using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LsRetuftRequired
    {
        [Description("Required: Code: 1. Length & Strength Retuft is required")]
        Required,

        [Description("Received: Code: 2. Length & Strength Retuft sample has been received in laboratory")]
        Received
    }
}
