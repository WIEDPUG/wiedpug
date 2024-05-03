using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PrintFlag
    {
        [Description("Normal: Code: P. Normal RPP/TCR request to pdf Certificate")]
        Normal,

        [Description("PdfCombinationOrOMLCertificateAndSublots: Code: A. Pdf Combination/OML Certificate and associated sub-lots")]
        PdfCombinationOrOMLCertificateAndSublots,

        [Description("PdfSublotsExcludingCombinationOrOMLCertificate: Code: S. Pdf associated sub-lots excluding the Combination/OML Certificate")]
        PdfSublotsExcludingCombinationOrOMLCertificate,

        [Description("PdfCombinationCertificateInChineseAndEnglish: Code: C. Pdf Combination Certificate in Chinese and English")]
        PdfCombinationCertificateInChineseAndEnglish,

        [Description("PdfCombinationCertificateInChineseAndSublotsInEnglish: Code: E. Pdf Combination Certificate in Chinese and English & associated sublots in English)")]
        PdfCombinationCertificateInChineseAndSublotsInEnglish,

        [Description("PdfCombinationCertificateInEnglishAndMulesingStatusReport: Code: M. Pdf Combination Certificate in English & Mulesing Status report")]
        PdfCombinationCertificateInEnglishAndMulesingStatusReport,

        [Description("PdfMulesingStatusReportOnly: Code: N. Pdf Mulesing Status report only")]
        PdfMulesingStatusReportOnly
    }
}
