using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeclaredQualifierCode
    {

        [Description("T: Qualifier not required")]
        T,

        [Description("H: Unscourable colour")]
        H,

        [Description("M: Scourable colour/creamy")]
        M,

        [Description("S: Dark Stain")]
        S,

        [Description("C: Cotts")]
        C,

        [Description("J: Jowls")]
        J,

        [Description("A: Dermatitis")]
        A,

        [Description("K: Kemp / Medullated")]
        K,

        [Description("Q: Dags")]
        Q,

        [Description("E: Necks (Not Scaled)")]
        E,

        [Description("N: Water Stain")]
        N,

        [Description("R: Brands")]
        R,

        [Description("G: Doggy (Not Scaled)")]
        G,

        [Description("D: Mud")]
        D,

        [Description("V: Skin pieces")]
        V,

        [Description("P: Shanks")]
        P,

        [Description("Y: Black & Grey")]
        Y,

        [Description("F: Soft Cotts")]
        F,

        [Description("U: Sweat/Frib")]
        U
    }
}
