using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordTypesToBeExcluded
    {
        [Description("00: Transmission Header")]
        _00,
        [Description("08: Inclusion List")]
        _08,
        [Description("08A: Exclusion List")]
        _08A,
        [Description("09: Final Receiver List")]
        _09,
        [Description("10:Wool Sale Header – Lots")]
        _10,
        [Description("12: Wool Sale Header – Groups")]
        _12,
        [Description("13: Lot Price and Buyer Details")]
        _13,
        [Description("14: Sale Status")]
        _14,
        [Description("20: Lot Header - Appraisal data")]
        _20,
        [Description("21A: Lot Header – Extension")]
        _21A,
        [Description("21B: Lot Header – Pricing Data")]
        _21B,
        [Description("21C: Lot Header - AWEX Data")]
        _21C,
        [Description("22A: Group Header")]
        _22A,
        [Description("22B: Group Header-Extension")]
        _22B,
        [Description("23A,: Lot Invoice Header")]
        _23A,
        [Description("23B: Lot Invoice – Extension")]
        _23B,
        [Description("24A: Lot Header")]
        _24A,
        [Description("24B: Lot Details")]
        _24B,
        [Description("25A: Lot Header – Vendor Declaration")]
        _25A,
        [Description("30: Lot Payment Detail")]
        _30,
        [Description("31: Fibre Diameter Histogram Header")]
        _31,
        [Description("32A: Fibre Diameter Histogram Detail")]
        _32A,
        [Description("36: Address")]
        _36,
        [Description("40A: Consignment Header")]
        _40A,
        [Description("40B: Consignment Extension (1)")]
        _40B,
        [Description("40C: Consignment Extension (2)")]
        _40C,
        [Description("42: Countermark/Headmark")]
        _42,
        [Description("44A: Delivery Order Detail")]
        _44A,
        [Description("44B: Delivery Order Detail Extension (1)")]
        _44B,
        [Description("44C: Delivery Order Detail Extension (2)")]
        _44C,
        [Description("45: Comment")]
        _45,
        [Description("50: Test Data Header")]
        _50,
        [Description("51C: Colour Details")]
        _51C,
        [Description("51D: Dichloromethane Test Details")]
        _51D,
        [Description("51E: Scoured Yield Extension")]
        _51E,
        [Description("51F: Premium TestDetails")]
        _51F,

        [Description("51I: Subjective Interlot Details")]
        _51I,

        [Description("51J: Combination Details")]
        _51J,

        [Description("51K: Length and Strength Combination Details")]
        _51K,

        [Description("51L: Length and Strength Details")]
        _51L,

        [Description("51M: OML Certificate Details")]
        _51M,
        [Description("51N: OMI Details")]
        _51N,
        [Description("51P: Core Test Details")]
        _51P,
        [Description("51R: Guidance Report Details")]
        _51R,
        [Description("51U: Length After Carding Test Details")]
        _51U,

        [Description("51V: Conditioning Test Details")]
        _51V,
        [Description("51W: Scoured Test Details")]
        _51W,
        [Description("51Y: Post sale Core Test Details")]
        _51Y,
        [Description("51X: Colour Combination Details")]
        _51X,
        [Description("51Z: Adjustment Note Details")]
        _51Z,
        [Description("52: Test Status Detail")]
        _52,
        [Description("53: Request for Data")]
        _53,
        [Description("54A: Contract Limit Requirements")]
        _54A,
        [Description("55: Core Test Request Verification")]
        _55,
        [Description("56: Dark and Medullated Fibre Risk Details")]
        _56,
        [Description("57: Request Post-Sale Printing of Pre-Sale Certificate")]
        _57,
        [Description("58: Certificate Request")]
        _58,
        [Description("59: Test Certificate Update Detail")]
        _60,

        [Description("60: Payment Detail")]
        _64D,
        [Description("64H: Payment Header")]
        _64H,
        [Description("65D: Statement Detail")]
        _65D,
        [Description("65H: Statement Header")]
        _65H,
        [Description("65T: Statement Trailer")]
        _65T,
        [Description("66: Miscellaneous Charge")]
        _66,
        [Description("67: Payment Summary")]
        _67,
        [Description("68: Other Details")]
        _68,
        [Description("79A:  Catalogue Lot Desc.")]
        _79A,
        [Description("79B: Interlot Component Bale Header")]
        _79B,
        [Description("80: Bale Header")]
        _80,
        [Description("85: Property Identification Codes")]
        _85,
        [Description("81: Bale Detail")]
        _81,
        [Description("84: Bale Identification")]
        _84,
        [Description("90: Transmission Response")]
        _90
    }
}