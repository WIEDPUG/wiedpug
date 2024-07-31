using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("A code to indicate the information.")]
    public enum InformationCode
    {
        [Description("OK: All data received OK. ")]
        OK,
    }
}
