using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("This field indicates the following: If an Australian Securities Exchange combination was requested and the combination satisfies the contract parameters of ASX the appropriate flag will be transmitted.")]
    public enum CombinationFlag
    {
        [Description("Normal: Code: N. Normal Combination")]
        Normal,

        [Description("ASX24: Code: S. ASX24 Combination (formerly SFE)")]
        ASX24,

        [Description("ASX19Point5: Code: 4. ASX19.5 54W Combination")]
        ASX19Point5,

        [Description("ASX21: Code: 5. ASX21.0 55W Combination")]
        ASX21,

        [Description("ASX22Point6: Code: 6. ASX22.6 56W Combination")]
        ASX22Point6,

        [Description("ASX19Point5AndASX21AndASX22Point6: Code: 7. ASX19.5 54W, ASX21.0 55W and ASX22.6 56W Combination")]
        ASX19Point5AndASX21AndASX22Point6,

        [Description("ASX19Point5AndASX21: Code: 8. ASX19.5 54W and ASX21.0 55W Combination")]
        ASX19Point5AndASX21,

        [Description("9: ASX21.0 55W and ASX22.6 56W Combination")]
        ASX21AndASX22Point6,

        [Description("ICAPWoolContractChinaType54P: Code: A. ICAP Wool Contract - China Type 54P")]
        ICAPWoolContractChinaType54P,

        [Description("ICAPWoolContractChinaType54: Code: B. ICAP Wool Contract - China Type 54")]
        ICAPWoolContractChinaType54,

        [Description("ICAPWoolContractChinaType55: Code: C. ICAP Wool Contract - China Type 55")]
        ICAPWoolContractChinaType55,

        [Description("ICAPWoolContractChinaType56: Code: D. ICAP Wool Contract - China Type 56")]
        ICAPWoolContractChinaType56,

        [Description("ICAPWoolContractChinaType424: Code: E. ICAP Wool Contract - China Type 424")]
        ICAPWoolContractChinaType424,

        [Description("ICAPWoolContractChinaTypeStandard: Code: F. ICAP Wool Contract - China Type Standard")]
        ICAPWoolContractChinaTypeStandard
    }
}
