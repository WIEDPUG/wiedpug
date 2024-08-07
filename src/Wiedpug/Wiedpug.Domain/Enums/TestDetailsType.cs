using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TestDetailsType

    {
        [Description("P: Core Test Details")]
        P,

        [Description("F: Premium Test Details")]
        F,

        [Description("I: Subjective Interlot Details")]
        I,

        [Description("M: OML Details")]
        M,

        [Description("N: OMI Details")]
        N,

        [Description("R: Guidane Report Details")]
        R,

        [Description("W: Sourced Test Details")]
        W,

        [Description("Y: Post-Sale Core Test Details")]
        Y

    }
}
