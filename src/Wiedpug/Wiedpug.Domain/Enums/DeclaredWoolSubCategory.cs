using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeclaredWoolSubCategory
    {
        [Description("CombingWeanersAndLambs: Code: W. Combing Weaners & Lambs")]
        CombingWeanersAndLambs,

        [Description("CardingLambs: Code: L. Carding Lambs")]
        CardingLambs,

        [Description("PluckedAndDead: Code: U. Plucked & Dead")]
        PluckedAndDead,

        [Description("ShornFromSkins: Code: K. Shorn from Skins")]
        ShornFromSkins,

        [Description("Fellmongered: Code: G. Fellmongered")]
        Fellmongered,

        [Description("Overgrown: Code: O. Overgrown")]
        Overgrown,

        [Description("NonconformingLot: Code: N. Non-conforming lot")]
        NonconformingLot,

        [Description("NotRequired: Code: T. Not required")]
        NotRequired
    }
}
