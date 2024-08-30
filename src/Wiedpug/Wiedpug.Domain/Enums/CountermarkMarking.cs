using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [Description("A code showing the method of applying countermarks.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CountermarkMarking

    {
        [Description("H: Hand Marking")]
        H,

        [Description("S: Stencilling")]
        S
    }
}
