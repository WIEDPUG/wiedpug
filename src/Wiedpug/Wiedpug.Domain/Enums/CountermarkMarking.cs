using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CountermarkMarking

    {
        [Description("H: Hand Marking")]
        H,

        [Description("S: Stencilling")]
        S
    }
}
