
using System.ComponentModel;
using System.Text.Json.Serialization;


namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LotType
    {
        [Description("P: Classed Grower Lot")]
        P = 1,

        [Description("M: Objectively Matched Lot")]
        M = 2,

        [Description("J: Combined Certificate")]
        J = 3,

        [Description("I: Subjectively Matched Interlot")]
        I = 4,

        [Description("B: Other Bulk Class Lot")]
        B = 5,

        [Description("U: Not Used")]
        U = 6,

        [Description("N: Objectively Matched Interlot")]
        N = 7,

        [Description("Q: Classed Bulk Class Lot – Quality Managed")]
        Q = 8,

        [Description("D: Other Grower Lot")]
        D = 9

    }
}
