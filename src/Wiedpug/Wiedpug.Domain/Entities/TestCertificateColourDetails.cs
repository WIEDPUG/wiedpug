using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class TestCertificateColourDetails
    {
        /// <summary>
        /// The certificate identity consists of a 1 digit prefix, followed by an 8 digit certificate number, followed by a 1 character suffix, followed by a 1 digit check number.It is printed at the top of the certificate.
        /// </summary>
        [Required]
        [StringLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; } // FIELD NUMBER 3 - Certificate Identity - Start: 4, Size: 11, Data Type: GR, Justification: F, Requirement Designator: M

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public required double Charge { get; set; } // FIELD NUMBER 4 - Charge - Start: 15, Size: 6, Data Type: D2, Justification: R, Requirement Designator: N/A, Value: spaces

        [Required]
        [StringLength(1)]
        public required Laboratory Laboratory { get; set; } // FIELD NUMBER 5 - Laboratory - Start: 21, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int RegrabSampleWeight { get; set; } // FIELD NUMBER 6 - Regrab Sample Weight - Start: 22, Size: 2, Data Type: N, Justification: R, Requirement Designator: C

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public required double ColourX { get; set; } // FIELD NUMBER 7 - Colour – X - Start: 24, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public required double ColourY { get; set; } // FIELD NUMBER 8 - Colour – Y - Start: 27, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M
        
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public required double ColourZ { get; set; } // FIELD NUMBER 9 - Colour – Z - Start: 30, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        [RegularExpression(RegexPattern.DECIMAL_4_1)]
        public double? ColourYZ { get; set; } // FIELD NUMBER 10 - Colour – Y – Z - Start: 33, Size: 4, Data Type: D1, Justification: R, Requirement Designator: C

        [StringLength(2)]
        public string? CoreBulkValue { get; set; } // FIELD NUMBER 11 - Core Bulk Value - Start: 37, Size: 2, Data Type: AN, Justification: F, Requirement Designator: C

        [Required]
        [StringLength(1)]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; } // FIELD NUMBER 12 - Re-issue Charge Flag - Start: 39, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? ColourXAsIs { get; set; } // FIELD NUMBER 14 - Colour – X (As–is) - Start: 48, Size: 3, Data Type: D1, Justification: R, Requirement Designator: C

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? ColourYAsIs { get; set; } // FIELD NUMBER 15 - Colour – Y (As–is) - Start: 51, Size: 3, Data Type: D1, Justification: R, Requirement Designator: C

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? ColourZAsIs { get; set; } // FIELD NUMBER 16 - Colour – Z (As–is) - Start: 54, Size: 3, Data Type: D1, Justification: R, Requirement Designator: C

        [RegularExpression(RegexPattern.DECIMAL_4_1)]
        public double? ColourYZAsIs { get; set; } // FIELD NUMBER 17 - Colour – Y – Z (As–is) - Start: 57, Size: 4, Data Type: D1, Justification: R, Requirement Designator: C

        [Required]
        [StringLength(1)]
        public required CalibrationFlag CalibrationFlag { get; set; } // FIELD NUMBER 18 - Calibration Flag - Start: 61, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        /// <summary>
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [StringLength(10)]
        public required string DateIssued { get; set; } // FIELD NUMBER 19 - Date Issued - Start: 62, Size: 6, Data Type: DATE, Justification: F, Requirement Designator: M
    }
}
