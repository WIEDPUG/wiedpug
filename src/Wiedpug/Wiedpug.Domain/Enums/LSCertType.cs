using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LsCertType
    {
        [Description("LengthAndStrengthTested: Code: 0. Length & Strength tested")]
        LengthAndStrengthTested = 0,

        [Description("LengthOnlyTestRequested: Code: 1. Length only test requested")]
        LengthOnlyTestRequested = 1,

        [Description("InsufficientStaples: Code: 2. Insufficient staples")]
        InsufficientStaples = 2
    }
}
