using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("A code for the country in which the transmission was created. Country Code using ISO 3166-1 standard")]
    public enum CountryCode
    {
        [Description("AU: Australia")]
        AU,

        [Description("NZ: New Zealand")]
        NZ,

        [Description("DE: Germany")]
        DE,

        [Description("IT: Italy")]
        IT,

        [Description("CN: China")]
        CN,

        [Description("TW: Taiwan")]
        TW,

        // [Description("FR: France")]
        // FR,
  
        // [Description("ZA: South Africa")]
        // ZA,

        // [Description("BE: Belgium")]
        // BE,

        // [Description("GB: United Kingdom of Great Britain")]
        // GB,

        // [Description("NL: Netherlands")]
        // NL,

        // [Description("US: USA")]
        // US,
    }
}
