using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeclaredQualifierCode
    {

        [Description("QualifierNotRequired: Code: T. Qualifier not required")]
        QualifierNotRequired,

        [Description("UnscourableColour: Code: H. Unscourable colour")]
        UnscourableColour,

        [Description("ScourableColourOrCreamy: Code: M. Scourable colour/creamy")]
        ScourableColourOrCreamy,

        [Description("DarkStain: Code: S. Dark Stain")]
        DarkStain,

        [Description("Cotts: Code: C. Cotts")]
        Cotts,

        [Description("Jowls: Code: J. Jowls")]
        Jowls,

        [Description("Dermatitis: Code: A. Dermatitis")]
        Dermatitis,

        [Description("KempMedullated: Code: K. Kemp / Medullated")]
        KempOrMedullated,

        [Description("Dags: Code: Q. Dags")]
        Dags,

        [Description("Necks: Code: E. Necks (Not Scaled)")]
        Necks,

        [Description("WaterStain: Code: N. Water Stain")]
        WaterStain,

        [Description("Brands: Code: R. Brands")]
        Brands,

        [Description("Doggy: Code: G. Doggy (Not Scaled)")]
        Doggy,

        [Description("Mud: Code: D. Mud")]
        Mud,

        [Description("SkinPieces: Code: V. Skin pieces")]
        SkinPieces,

        [Description("Shanks: Code: P. Shanks")]
        Shanks,

        [Description("BlackAndGrey: Code: Y. Black & Grey")]
        BlackAndGrey,

        [Description("SoftCotts: Code: F. Soft Cotts")]
        SoftCotts,

        [Description("SweatOrFrib: Code: U. Sweat/Frib")]
        SweatOrFrib
    }
}
