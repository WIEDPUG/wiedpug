using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class LengthAndStrengthTestDetail
    {
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required LengthAndStrengthTestDetailType lengthAndStrengthTestDetailsType { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [MinLength(6)]
        [MaxLength(15)]
        public Currency? Charge { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required Laboratory Laboratory { get; set; }

        /// <summary>
        /// The weight of a regrab sample, a grab sample taken after the wool has 
        /// been initially sampled and tested, is shown on the new certificate.
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; }

        /// <summary>
        /// The mean length of a staple from tip to base. At least 60 staples are measured for each test lot.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public required int StapleLength { get; set; }

        /// <summary>
        /// The mean length of a staple from tip to base. At least 60 staples are measured for each test lot. 
        ///
        /// Minimum - the lowest value in a range of staple length values.
        /// </summary>
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? StapleLengthMinimum { get; set; }

        /// <summary>
        /// The mean length of a staple from tip to base. At least 60 staples are measured for each test lot. 
        ///
        /// Maximum - the highest value in a range of staple length values.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? StapleLengthMaximum { get; set; }

        /// <summary>
        /// The force required to break a staple of given thickness. 
        ///
        /// The average strength is expressed in Newtons per kilotex.Individual staples range in strength from 0 to 100 Newtons per kilotex
        ///
        /// Minimum - The lowest value in a range of staple strength values 
        /// </summary>
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? StapleStrengthMinimum { get; set; }

        /// <summary>
        /// The force required to break a staple of given thickness. 
        ///
        /// The average strength is expressed in Newtons per kilotex.Individual staples range in strength from 0 to 100 Newtons per kilotex
        ///
        /// Maximum - The highest value in a range of staple strength value
        /// </summary>
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? StapleStrengthMaximum { get; set; }


        /// <summary>
        /// Staple length coefficient of variation. This is a measurement of the staple length variability and is reported as a percentage.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int StapleLengthCvPercentage { get; set; }

        /// <summary>
        /// The force required to break a staple of given thickness. 
        ///
        /// The average strength is expressed in Newtons per kilotex.Individual staples range in strength from 0 to 100 Newtons per kilotex
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public required int StapleStrength { get; set; }

        /// <summary>
        /// The position of break indicates the location of the weakest part of the staple.
        ///
        /// Tip - Percentage of wool staple with a tip section position of break.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public required int PositionOfBreakPercentageTip { get; set; }

        /// <summary>
        /// The position of break indicates the location of the weakest part of the staple. 
        ///
        /// Middle - Percentage of wool staples with a middle section position of break.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public required int PositionOfBreakPercentageMiddle { get; set; }

        /// <summary>
        /// The position of break indicates the location of the weakest part of the staple.
        /// 
        /// Base - Percentage of wool staples with a base section position of break.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public required int PositionOfBreakPercentageBase { get; set; }

        /// <summary>
        /// Predicted Fibre Length in the Top. NOTE: Any certificate issued (or reissued with a new Certificate ID Number) from 1st July, 2006 will be based on the TEAM-3 calculations. 
        ///
        /// Anything issued prior to 1st July, 2006 will be based on the TEAM-2 calculations.
        ///
        /// A check against the Date Issued field in the Length and Strength Details record will determine which TEAM formula has been used.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? Team3Hauteur { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public ReissueChargeFlag? ReissueChargeFlag { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required LsCertType LsCertType { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the LS-sample is secured.
        ///
        /// true: secured
        ///
        /// false: not secured
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(5)]
        public required bool IsLsSampleSecured { get; set; }

        /// <summary>
        /// Expected Barbe length in the Top. Used for NZ Crossbred wool certificates based on the 2016 calculation. 
        ///
        /// Any Length and Strength certificate for NZ Crossbred wool will include a calculated Barbe value based on the 2016 calculation.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? ExpectedBarbe { get; set; }

        /// <summary>
        /// Coefficient of Variation of Hauteur. NOTE: Refer to note in Team3Hauteur.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? Team3HauteurCvPercentage { get; set; }

        /// <summary>
        /// Romaine. NOTE: Refer to note in Team3Hauteur.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? Team3RomainePercentage { get; set; }

        /// <summary>
        /// Date in ISO 8601 standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [Required]
        [MinLength(1)]
        [MaxLength(10)]
        public required string DateIssued { get; set; }

        /// <summary>
        /// Average Staple Strength of the lowest 25% of staples measured for Strength.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? StapleStrengthLowest25Percent { get; set; }
    }
}
