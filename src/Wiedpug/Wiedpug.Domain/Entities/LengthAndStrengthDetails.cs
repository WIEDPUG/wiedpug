using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class LengthAndStrengthDetails
    {
        [Required]
        public required string CertificateIdentity { get; set; }
        [Required]
        public required string Charge { get; set; }
        [Required]
        public required string Laboratory { get; set; }

        public int? RegrabSampleWeight { get; set; }

        [Required]
        public required int StapleLength { get; set; }

        [Required]
        public required int StapleLengthCV { get; set; }

        [Required]
        public required int StapleStrength { get; set; }

        [Required]
        public required int PositionOfBreakTip { get; set; }

        [Required]
        public required int PositionOfBreakMiddle { get; set; }

        [Required]
        public required int PositionOfBreakBase { get; set; }

        public int? TEAM3Hauteur { get; set; }

        [Required]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [Required]
        public required LSCertType LSCertType { get; set; }

        /// <summary>
        /// Specifies whether the L/S sample is secured or not. <br />
        /// true for a secured L/S sample <br />
        /// flase for a unsecured L/S sample <br />
        /// </summary>
        [Required]
        public required Boolean isLSSampleSecured { get; set; }

        public int? ExpectedBarbe { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? TEAM3HauteurCV { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? TEAM3Romaine { get; set; }

        /// <summary>
        /// Date and Time with offset value in ISO 8601 standard. e.g. 2024-03-21T19:25:04+00:00
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [Required]
        public required string DateIssued { get; set; }

        public int? StapleStrengthLowest25Percent { get; set; }
    }
}
