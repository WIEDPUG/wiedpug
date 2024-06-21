using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Currency
    {
        [Description("AED: United Arab Emirates Dirham")]
        AED,

        [Description("CAD: Canadian Dollar")]
        CAD,

        [Description("CHF: Swiss Franc")]
        CHF,

        [Description("CZK: Czech Koruna")]
        CZK,

        [Description("DKK: Danish Kroner")]
        DKK,

        [Description("EUR: Euro")]
        EUR,

        [Description("GBP: Great British Pound")]
        GBP,

        [Description("HKD: Hong Kong Dollar")]
        HKD,

        [Description("HUF: Hungarian Forint")]
        HUF,
        [Description("ILS: Israeli New Shekel")]
        ILS,

        [Description("JPY: Japanese Yen")]
        JPY,

        [Description("NOK: Norwegian Kroner")]
        NOK,

        [Description("NZD: New Zealand Dollar")]
        NZD,

        [Description("SEK: Swedish Kronor")]
        SEK,

        [Description("SGD: Singapore Dollar")]
        SGD,

        [Description("THB: Thailand Baht")]
        THB,

        [Description("USD: United States Dollar")]
        USD,

        [Description("ZAR: South African Rand")]
        ZAR
    }
}
