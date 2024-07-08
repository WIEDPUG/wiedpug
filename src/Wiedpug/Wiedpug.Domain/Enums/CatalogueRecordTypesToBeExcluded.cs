using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CatalogueRecordTypesToBeExcluded
    {
        LotHeaderPricing,

        LotHeaderAwexData,

        LotHeaderVendorDeclaration,

        ColourDetails,

        InterlotComponentBaleHeader,

        BaleIdentification,

        FibreDiameterHistogramHeader,

        FibreDiameterHistogramDetails
    }
}