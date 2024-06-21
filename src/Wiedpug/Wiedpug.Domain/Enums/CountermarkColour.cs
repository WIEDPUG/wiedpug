using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CountermarkColour

    {
        [Description("B: Black")]
        B,

        [Description("R: Red")]
        R
    }
}
