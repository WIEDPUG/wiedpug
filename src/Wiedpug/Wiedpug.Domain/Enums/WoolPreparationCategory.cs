using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WoolPreparationCategory
    {
        [Description("BulkClass: Code: B. Bulk Class")]
        BulkClass,

        [Description("PresaleTestCertificateOtherGrowerLot: Code: D. PTC (Pre-Sale Test Certificate – Other Grower Lot)")]
        PresaleTestCertificateOtherGrowerLot,

        [Description("PremiumTest: Code: F. Premium Test")]
        PremiumTest,

        [Description("SubjectivelyAppraisedInterlot: Code: I. Subjectively Appraised Interlot")]
        SubjectivelyAppraisedInterlot,

        [Description("PresaleTestCertificateClassedGrowerLot: Code: P. PTC (Pre-sale Test Certificate - Classed Grower Lot)")]
        PresaleTestCertificateClassedGrowerLot,

        [Description("BulkClassQualityManaged: Code: Q. Bulk Class – Quality Managed")]
        BulkClassQualityManaged
    }
}
