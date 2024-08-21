using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TestDetailType

    {
        [Description("C: Combination Detail")]
        C,

        [Description("P: Core Test Detail")]
        P,

        [Description("F: Premium Test Detail")]
        F,

        [Description("I: Subjective Interlot Detail")]
        I,

        [Description("M: OML Detail")]
        M,

        [Description("N: OMI Detail")]
        N,

        [Description("R: Guidance Report Detail")]
        R,

        [Description("W: Scoured Test Detail")]
        W,

        [Description("Y: Post-Sale Core Test Detail")]
        Y

    }
}
