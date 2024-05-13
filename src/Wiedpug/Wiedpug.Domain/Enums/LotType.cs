
using System.ComponentModel;
using System.Text.Json.Serialization;


namespace Wiedpug.Domain.Enums
{
    [Description("A code used to describe wool lot preparation. " +
        "It is not wool type. " +
        "`*` wool meets clip preparation guidelines.`#` wool does not necessarily meet clip preparation guidelines")]
    public enum LotType
    {
        [Description("1: (Suffix - P) Classed Grower Lot *")]
        ClassedGrowerLot = 1,

        [Description("2: (Suffix - M) Objectively Matched Lot")]
        ObjectivelyMatchedLot = 2,

        [Description("3: (Suffix - J) Combined Certificate")]
        CombinedCertificate = 3,

        [Description("4: (Suffix - I) Subjectively Matched Interlot")]
        SubjectivelyMatchedInterlot = 4,

        [Description("5: (Suffix - B) Other Bulk Class Lot #")]
        OtherBulkClassLot = 5,

        [Description("6: Not Used")]
        NotUsed = 6,

        [Description("7: (Suffix - N) Objectively Matched Interlot")]
        ObjectivelyMatchedInterlot = 7,

        [Description("8: (Suffix - Q) Classed Bulk Class Lot – Quality Managed *")]
        ClassedBulkClassLotQualityManaged = 8,

        [Description("9: (Suffix - D) Other Grower Lot #")]
        OtherGrowerLot = 9

    }
}
