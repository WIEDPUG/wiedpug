using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordTypesToBeExcludedForAuctionCatalogue
    {
        [Description("21: Lot Header")]
        _21,

        [Description("51C: Colour Details")]
        _51C,

        [Description("79B: Interlot component bale header")]
        _79B,

        [Description("84: Bale Identification")]
        _84,

        [Description("31: Fibre Diameter Histogram Header")]
        _31,

        [Description("32A: Fibre Diameter Histogram Details")]
        _32A
    }
}
