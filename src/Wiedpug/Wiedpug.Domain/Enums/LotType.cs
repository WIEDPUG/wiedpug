using System.ComponentModel;

namespace Wiedpug.Domain.Enums
{
    [Description("A code used to describe wool lot preparation. " +
        "It is not wool type. " +
        "`*` wool meets clip preparation guidelines.`#` wool does not necessarily meet clip preparation guidelines")]
    public enum LotType
    {
        [Description("1: (Suffix - P) Classed Grower Lot *")]
        P = 1,
        [Description("2: (Suffix - M) Objectively Matched Lot")]
        M = 2,
        [Description("3: (Suffix - J) Combined Certificate")]
        J = 3,
        [Description("4: (Suffix - I) Subjectively Matched Interlot")]
        I = 4,
        [Description("5: (Suffix - B) Other Bulk Class Lot #")]
        B = 5,
        [Description("6: Not Used")]
        NotUsed = 6,
        [Description("7: (Suffix - N) Objectively Matched Interlot")]
        N = 7,
        [Description("8: (Suffix - Q) Classed Bulk Class Lot – Quality Managed *")]
        Q = 8,
        [Description("9: (Suffix - D) Other Grower Lot #")]
        D = 9
    }
}