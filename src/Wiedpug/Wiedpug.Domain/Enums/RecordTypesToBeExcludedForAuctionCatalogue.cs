using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [RemoveUnderscoreFromEnumItem]
    [Description("")]
    public enum RecordTypesToBeExcludedForAuctionCatalogue
    {
        [Description("21: Lot Header")]
        [EnumMember(Value = "21")]
        _21,

        [Description("51C: Colour Details")]
        [EnumMember(Value = "51C")]
        _51C,

        [Description("79B: Interlot component bale header")]
        [EnumMember(Value = "79B")]
        _79B,

        [Description("84: Bale Identification")]
        [EnumMember(Value = "84")]
        _84,

        [Description("31: Fibre Diameter Histogram Header")]
        [EnumMember(Value = "31")]
        _31,

        [Description("32A: Fibre Diameter Histogram Details")]
        [EnumMember(Value = "32A")]
        _32A,
    }
}
