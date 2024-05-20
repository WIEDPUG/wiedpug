using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum LsCertType
    {
        [Description("0: Length & Strength tested")]
        LengthAndStrengthTested = 0,

        [Description("1: Length only test requested")]
        LengthOnlyTestRequested = 1,

        [Description("2: Insufficient staples")]
        InsufficientStaples = 2
    }
}
