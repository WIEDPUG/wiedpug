using System.ComponentModel;
using System.Text.Json.Serialization;


namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]    
    public enum SubClassToBeExcluded
    {
        [Description("A: First record of one type")]
        A,

        [Description("B: Second record of that type")]
        B,

        [Description("C: Colour Certificate record")]
        C,

        [Description("D: Detail record")]
        D,

        [Description("E: Scoured Yield Extension")]
        E,

        [Description("F: Premium Certificate record")]
        F,

        [Description("H: Header record")]
        H,

        [Description("I: Subjective Interlot Certificate record")]
        I,

        [Description("J: Combination Certificate record")]
        J,

        [Description("K: Length and Strength Combination Certificate record")]
        K,

        [Description("L: Length and Strength Certificate Record")]
        L,

        [Description("M: Objectively Matched Lot Certificate Record")]
        M,

        [Description("N: Objectively Matched Interlot Certificate Record")]
        N,
        [Description("P: Core Test Certificate Record")]
        P,

        [Description("R: Guidance Report Details")]
        R,

        [Description("T: Trailer record")]
        T,

        [Description("U: Length After Carding Test Details")]
        U,

        [Description("V:Conditioning Test Details")]
        V,

        [Description("W: Scoured Test Details")]
        W,

        [Description("X: Colour Combination Certificate Record")]
        X,

        [Description("Y: Post sale Core Test Detail")]
        Y,
        [Description("Z: Adjustment Note Details")]
        Z
    }
}