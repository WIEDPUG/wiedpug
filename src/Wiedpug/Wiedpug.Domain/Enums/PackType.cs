using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("A code used to indicate how the wool has been baled. The most common type is Farm bales. <strong>Original</strong> - the pack type when the wool was originally baled. <strong>Preferred</strong> - The pack type which the buyer would prefer to be used when his wool is dumped.")]
    public enum PackType
    {
        [Description("StandardBale: Code: 0. Standard (farm) bale")]
        StandardBale,

        [Description("BagOrButt: Code: 1. Bag/butt")]
        BagOrButt,

        [Description("LightweightBale: Code: 2. Lightweight bale")]
        LightweightBale,

        [Description("JumboBale: Code: 3. Jumbo bale")]
        JumboBale,

        [Description("SingleBalesNormalDensityDumped: Code: 4. Single bales (normal density dumped)")]
        SingleBalesNormalDensityDumped,

        [Description("SingleBalesHighDensityDumped: Code: 5. Single bales (high density dumped)")]
        SingleBalesHighDensityDumped,

        [Description("SingleBalesSuperHighDensityDumped: Code: 6. Single bales (super high density dumped)")]
        SingleBalesSuperHighDensityDumped,

        [Description("BaleTripackSuperHighDensityDumped: Code: 7. 3 bale tripack (super high density dumped)")]
        ThreeBaleTripack,

        [Description("TwoBaleTripac: Code: 8. 2 bale tripack (super high density dumped)")]
        TwoBaleTripack,

        [Description("UBales: Code: 9. U bales")]
        UBales,

        [Description("FourOrSixBaleUnitisedNormalDensityDumped: Code: A. 4 or 6 bale unitised (normal density dumped)")]
        FourOrSixBaleUnitisedNormalDensityDumped,

        [Description("FourOrSixBaleUnitisedHighDensityDumped: Code: B. 4 or 6 bale unitised (high density dumped)")]
        FourOrSixBaleUnitisedHighDensityDumped,

        [Description("FourOrSixBaleUnitisedSuperHighDensityDumped: Code: C. 4 or 6 bale unitised (super high density dumped)")]
        FourOrSixBaleUnitisedSuperHighDensityDumped,

        [Description("TwoBaleModule: Code: D. Two Bale Module (2BM)")]
        TwoBaleModule,

        [Description("J9SizeBaleForScouredWool: Code: E. J9 size bale used for scoured wool")]
        J9SizeBaleForScouredWool,

        [Description("J12SizeBaleForScouredWool: Code: F. J12 size bale used for scoured wool")]
        J12SizeBaleForScouredWool,

        [Description("Mixed: Code: Z. Mixed (to be used with groups only, that is, record type 12)")]
        Mixed
    }
}
