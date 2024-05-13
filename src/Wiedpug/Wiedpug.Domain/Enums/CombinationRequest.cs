using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CombinationRequest
    {
        [Description("N: Normal Combination Reuqest")]
        N,

        [Description("S: ASX24 Combination Request (formerly SFE)")]
        S,

        [Description("X: ASX19.5 54W, ASX21.0 55W or ASX22.6 56W Combination Request")]
        X,

        [Description("4: ASX19.5 54W Combination Request")]
        _4,

        [Description("5: ASX21.0 55W Combination Request")]
        _5,

        [Description("6: ASX22.6 56W Combination Request")]
        _6,

        [Description("C: China Contract Combination Request")]
        C
    }
}
