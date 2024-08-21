using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [Description("This field indicates what type of certificate is being requested.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CertificateType
    {
        [Description("B: Bulk Class")]
        B,

        [Description("C: Colour")]
        C,

        [Description("F: Premium")]
        F,

        [Description("I: Subjectively Appraised Interlot")]
        I,

        [Description("L: Combination")]
        J,

        [Description("K: Length & Strength Combination")]
        K,

        [Description("L: Length & Strength")]
        L,

        [Description("M: Objectively Matched Lot")]
        M,

        [Description("N: Objectively matched Interlot")]
        N,

        [Description("Q: Bulk Class – Quality Managedt")]
        Q,

        [Description("P: PTC")]
        P,

        [Description("R: Guidance Report")]
        R,

        [Description("S: Update Sale Identity and Lot Identity on Core Test or OML’s for Sale. Catalogues where certificate is not being printed")]
        S,

        [Description("U: Uncombination of OML or Combination certificate")]
        U,

        [Description("W: Scoured Wool")]
        W,

        [Description("X: Colour Combination")]
        X,

        [Description("Y: Post sale Core Test")]
        Y,
    }
}
