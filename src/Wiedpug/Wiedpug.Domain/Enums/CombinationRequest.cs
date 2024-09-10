using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{
    [Description("For Australian Securities Exchange Combination requests, if an 'X' is requested, at least one of the three ASX 54W, 55W or 56W contract specifications must be satisfied for a certificate to be issued, whilst if 4, 5 or 6 is requested it must satisfy the requested contract for a certificate to be issued. Note: all 3 ASX contract specifications will be checked and the issued certificate will indicate all contracts that are satisfied. If an 'S' is requested only the ASX24 contract specification will be checked.")]
    [RemoveUnderscoreFromEnumItem]
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
