using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CombinationRequest
    {
        [Description("Normal: Code: N. Normal Combination Reuqest")]
        Normal,

        [Description("ASX24: Code: S. ASX24 Combination Request (formerly SFE)")]
        ASX24,

        [Description("ASX19Point5OrASX21OrASX22Point6: Code: X. ASX19.5 54W, ASX21.0 55W or ASX22.6 56W Combination Request")]
        ASX19Point5OrASX21OrASX22Point6,

        [Description("ASX19Point5: Code: 4. ASX19.5 54W Combination Request")]
        ASX19Point5,

        [Description("ASX21: Code: 5. ASX21.0 55W Combination Request")]
        ASX21,

        [Description("ASX22Point6: Code: 6. ASX22.6 56W Combination Request")]
        ASX22Point6,

        [Description("ChinaContract: Code: C. China Contract Combination Request")]
        ChinaContract
    }
}
