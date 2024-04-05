using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class ColorDetails
    {
        [Required]
        public required string CertificateIdentity { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double Charge { get; set; }

        [Required]
        public required string Laboratory { get; set; }

        public int? RegrabSampleWeight { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public required double ColourX { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public required double ColourY { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public required double ColourZ { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? ColourYZ { get; set; }

        public string? CoreBulkValue { get; set; }

        [Required]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double ColourXAsIs { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double ColourYAsIs { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double ColourZAsIs { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? ColourYZAsIs { get; set; }

        [Required]
        public CalibrationFlag CalibrationFlag { get; set; }

        /// <summary>
        /// Date value in ISO 8601 standard. e.g. 2024-03-21
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string DateIssued { get; set; }
    }
}
