using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CurrencyUnit
    {
        [Description("AUD: Australian Dollars")]
        AUD,

        [Description("BEF: Belgian Francs")]
        BEF,

        [Description("NZD: New Zealand Dollars")]
        NZD,

        [Description("BGP: British Pounds")]
        BGP,

        [Description("FRF: French Francs")]
        FRF,

        [Description("DEM: German Deutsche Marks")]
        DEM,

        [Description("ITL: Italy Lire")]
        ITL,

        [Description("CNY: Chinese Yuan")]
        CNY,

        [Description("ANG: Netherlands Antilles Guilders")]
        ANG,
        
        [Description("BEF: Taiwan New Dollars")]
        TWD,

        [Description("ZAR: South Africa Rand")]
        ZAR,

        [Description("USD: USA Dollars")]
        USD,

        [Description("EUR: Euro")]
        EUR,
    }
}
