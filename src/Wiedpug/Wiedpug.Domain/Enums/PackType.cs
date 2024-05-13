using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("A code used to indicate how the wool has been baled. The most common type is Farm bales. <strong>Original</strong> - the pack type when the wool was originally baled. <strong>Preferred</strong> - The pack type which the buyer would prefer to be used when his wool is dumped.")]
    public enum PackType
    {
        [Description("0: Standard (farm) bale")]
        _0,

        [Description("B1: Bag/butt")]
        _1,

        [Description("2: Lightweight bale")]
        _2,

        [Description("3: Jumbo bale")]
        _3,

        [Description("4: Single bales (normal density dumped)")]
        _4,

        [Description("5: Single bales (high density dumped)")]
        _5,

        [Description("6: Single bales (super high density dumped)")]
        _6,

        [Description("7: 3 bale tripack (super high density dumped)")]
        _7,

        [Description("8: 2 bale tripack (super high density dumped)")]
        _8,

        [Description("9: U bales")]
        _9,

        [Description("A: 4 or 6 bale unitised (normal density dumped)")]
        A,

        [Description("B: 4 or 6 bale unitised (high density dumped)")]
        B,

        [Description("C: 4 or 6 bale unitised (super high density dumped)")]
        C,

        [Description("D: Two Bale Module (2BM)")]
        D,

        [Description("E: J9 size bale used for scoured wool")]
        E,

        [Description("F: J12 size bale used for scoured wool")]
        F,

        [Description("Z: Mixed (to be used with groups only, that is, record type 12)")]
        Z
    }
}
