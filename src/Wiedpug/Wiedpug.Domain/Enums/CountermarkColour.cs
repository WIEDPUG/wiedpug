using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [Description("A code showing the colour of lettering used for applying countermarks.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CountermarkColour

    {
        [Description("B: Black")]
        B,

        [Description("R: Red")]
        R
    }
}
