using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [RemoveUnderscoreFromEnumItem]
    [Description("This field indicates the following: If an Australian Securities Exchange combination was requested and the combination satisfies the contract parameters of ASX the appropriate flag will be transmitted.")]
    public enum CombinationFlag
    {
        [Description("N. Normal Combination")]
        N,

        [Description("S. ASX24 Combination (formerly SFE)")]
        S,

        [Description("4. ASX19.5 54W Combination")]
        _4,

        [Description("5. ASX21.0 55W Combination")]
        _5,

        [Description("6. ASX22.6 56W Combination")]
        _6,

        [Description("7. ASX19.5 54W, ASX21.0 55W and ASX22.6 56W Combination")]
        _7,

        [Description("8. ASX19.5 54W and ASX21.0 55W Combination")]
        _8,

        [Description("9: ASX21.0 55W and ASX22.6 56W Combination")]
        _9,

        [Description("A. ICAP Wool Contract - China Type 54P")]
        A,

        [Description("B. ICAP Wool Contract - China Type 54")]
        B,

        [Description("C. ICAP Wool Contract - China Type 55")]
        C,

        [Description("D. ICAP Wool Contract - China Type 56")]
        D,

        [Description("E. ICAP Wool Contract - China Type 424")]
        E,

        [Description("F. ICAP Wool Contract - China Type Standard")]
        F
    }
}
