using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class LengthAndStrengthDetails
    {
        [Required]
        [StringLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_6_2)]
        public required double Charge { get; set; }

        [Required]
        [StringLength(1)]
        public required Laboratory Laboratory { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? RegrabSampleWeight { get; set; }

        /// <summary>
        /// The mean length of a staple from tip to base. At least 60 staples are measured for each test lot.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public required int StapleLength { get; set; }

        /// <summary>
        /// Staple length coefficient of variation. This is a measurement of the staple length variability and is reported as a percentage.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int StapleLengthCvPercentage { get; set; }

        /// <summary>
        /// The force required to break a staple of given thickness. 
        /// The average strength is expressed in Newtons per kilotex.Individual staples range in strength from 0 to 100 Newtons per kilotex
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public required int StapleStrength { get; set; }

        /// <summary>
        /// The position of break indicates the location of the weakest part of the staple.
        /// Tip - Percentage of wool staple with a tip section position of break.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public required int PositionOfBreakPercentageTip { get; set; }

        /// <summary>
        /// The position of break indicates the location of the weakest part of the staple. 
        /// Middle - Percentage of wool staples with a middle section position of break.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public required int PositionOfBreakPercentageMiddle { get; set; }

        /// <summary>
        /// The position of break indicates the location of the weakest part of the staple. 
        /// Base - Percentage of wool staples with a base section position of break.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public required int PositionOfBreakPercentageBase { get; set; }

        /// <summary>
        /// Predicted Fibre Length in the Top. NOTE: Any certificate issued (or reissued with a new Certificate ID Number) from 1st July, 2006 will be based on the TEAM-3 calculations. 
        /// Anything issued prior to 1st July, 2006 will be based on the TEAM-2 calculations.
        /// A check against the Date Issued field in the 51L or 51K record will determine which TEAM formula has been used.
        /// </summary>
        /// 
        [Range(0, 99)]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? Team3Hauteur { get; set; }

        [Required]
        [StringLength(1)]
        public required LsCertType LsCertType { get; set; }

        /// <summary>
        /// Specifies whether the L/S sample is secured or not. <br />
        /// true: for a secured L/S sample <br />
        /// flase: for a unsecured L/S sample <br />
        /// </summary>
        [Required]
        [StringLength(5)]
        public required bool isLsSampleSecured { get; set; }

        /// <summary>
        /// Expected Barbe length in the Top. Used for NZ Crossbred wool certificates based on the 2016 calculation. 
        /// Any Length and Strength certificate for NZ Crossbred wool will include a calculated Barbe value based on the 2016 calculation.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? ExpectedBarbe { get; set; }

        /// <summary>
        /// Coefficient of Variation of Hauteur. NOTE: Refer to note in `Team3Hauteur`.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? Team3HauteurCvPercentage { get; set; }

        /// <summary>
        /// Romaine. NOTE: Refer to note in `Team3Hauteur`.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? Team3RomainePercentage { get; set; }

        /// <summary>
        /// Date in ISO 8601 standard UTC date format. e.g. 2024-03-21
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [Required]
        [StringLength(10)]
        public required string DateIssued { get; set; }

        /// <summary>
        /// Average Staple Strength of the lowest 25% of staples measured for Strength.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? StapleStrengthLowest25Percent { get; set; }
    }
}
