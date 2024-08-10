using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OpeningOrClosingType
    {
        [Description("Opening: Opening Balance")]
        Opening,

        [Description("Closing: Closing Balance")]
        Closing,
    }
}
