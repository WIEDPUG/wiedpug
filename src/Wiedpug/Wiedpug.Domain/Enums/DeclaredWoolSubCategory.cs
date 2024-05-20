using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeclaredWoolSubCategory
    {
        [Description("W: Combing Weaners & Lambs")]
        W,

        [Description("L: Carding Lambs")]
        L,

        [Description("U: Plucked & Dead")]
        U,

        [Description("K: Shorn from Skins")]
        K,

        [Description("G: Fellmongered")]
        G,

        [Description("O: Overgrown")]
        O,

        [Description("N: Non-conforming lot")]
        N,

        [Description("T: Not required")]
        T
    }
}
