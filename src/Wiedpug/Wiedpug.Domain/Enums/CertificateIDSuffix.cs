using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CertificateIdSuffix
    {
        [Description("B: Bulk Class")]
        B,

        [Description("C: Colour")]
        C,

        [Description("D: PTC (Pre-Sale Test Certificate – Other Grower Lot)")]
        D,

        [Description("F: Premium Test")]
        F,

        [Description("I: Subjectively Appraised Interlot")]
        I,

        [Description("J: Combination - Yield & Micron, Length & Strength, Colour")]
        J,

        [Description("L: Length & Strength")]
        L,

        [Description("M: Objectively Matched Lot")]
        M,

        [Description("N: Objectively matched Interlot")]
        N,

        [Description("Q: Bulk Class – Quality Managed")]
        Q,

        [Description("P: PTC (Pre-sale Test Certificate - Classed Grower Lot)")]
        P,

        [Description("R: Guidance Report")]
        R,

        [Description("W: Scoured Wool")]
        W,

        [Description("Y: Post sale Core Test")]
        Y,
    }
}