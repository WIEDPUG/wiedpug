using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("Country Code using ISO 3166-1 standard")]
    public enum CountryCode
    {
        [Description("AU: Australia")]
        AU,

        [Description("NZ: New Zealand")]
        NZ,

        [Description("FR: France")]
        FR,

        [Description("ZA: South Africa")]
        ZA
    }
}
