using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordTypesToBeExcludedForAuctionCatalogue
    {
        [Description("LotHeader: Code: 21. Lot Header")]
        LotHeader,

        [Description("ColourDetails: Code: 51C. Colour Details")]
        ColourDetails,

        [Description("InterlotComponentBaleHeader: Code: 79B. Interlot component bale header")]
        InterlotComponentBaleHeader,

        [Description("BaleIdentification: Code: 84. Bale Identification")]
        BaleIdentification,

        [Description("FibreDiameterHistogramHeader: Code: 31. Fibre Diameter Histogram Header")]
        FibreDiameterHistogramHeader,

        [Description("FibreDiameterHistogramDetails: Code: 32A. Fibre Diameter Histogram Details")]
        FibreDiameterHistogramDetails
    }
}
