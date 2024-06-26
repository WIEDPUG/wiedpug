using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SellingCentreType
    {
        [Description("NZ_C: Christchurch")]
        NZ_C,

        [Description("NZ_N: Napier")]
        NZ_N,

        [Description("AU_A: Adelaide")]
        AU_A,

        [Description("AU_AU: Australia")]
        AU_AU,

        [Description("AU_B: Brisbane")]
        AU_B,

        [Description("AU_F: Fremantle")]
        AU_F,

        [Description("AU_G: Geelong")]
        AU_G,

        [Description("AU_L: Launceston")]
        AU_L,

        [Description("AU_M: Melbourne")]
        AU_M,

        [Description("AU_N: Newcastle")]
        AU_N,

        [Description("AU_R: Goulburn")]
        AU_R,

        [Description("AU_S: Sydney")]
        AU_S,

        [Description("PS: Private Sales")]
        PS,

        [Description("T: Auctions Plus Sales")]
        T
    }
}
