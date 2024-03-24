using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("Country Code using ISO 3166-1 standard")]
    public enum CountryCode
    {
        [Description("Australia: AU")]
        AU,

        [Description("New Zealand: NZ")]
        NZ,

        [Description("France: FR")]
        FR,

        [Description("South Africa: ZA")]
        ZA
    }
}
