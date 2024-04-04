using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class OMLDetails
    {
        [Required]
        public required string CertificateIdentity { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal Charge { get; set; }

        [Required]
        public required string Laboratory { get; set; }

        public int? RegrabSampleWeight { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public decimal? WoolBase { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public decimal? AirflowMean { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public decimal VMB { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public decimal HardHeadsBase { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required string Yield1 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public string? Yield2 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public string? Yield3 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public string? Yield4 { get; set; }

        public YieldType? YieldType1 { get; set; }

        public YieldType? YieldType2 { get; set; }

        [Required]
        public required RetestFlag RetestFlag { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public string? Yield5 { get; set; }

        [Required]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public string? VM1 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public string? VM2 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public string? VM3 { get; set; }

        [Required]
        /// <summary>
        /// six digits number string        
        /// </summary>
        [RegularExpression(RegexPattern.STRING_SIX_DIGITS_BEFORE_DECIMAL_POINT)]
        public required string CleanWeight1 { get; set; }

        /// <summary>
        /// six digits number string        
        /// </summary>
        [RegularExpression(RegexPattern.STRING_SIX_DIGITS_BEFORE_DECIMAL_POINT)]
        public string? CleanWeight2 { get; set; }

        /// <summary>
        /// six digits number string        
        /// </summary>
        [RegularExpression(RegexPattern.STRING_SIX_DIGITS_BEFORE_DECIMAL_POINT)]
        public string? CleanWeight3 { get; set; }

        /// <summary>
        /// six digits number string        
        /// </summary>
        [RegularExpression(RegexPattern.STRING_SIX_DIGITS_BEFORE_DECIMAL_POINT)]
        public string? CleanWeight4 { get; set; }

        /// <summary>
        /// six digits number string        
        /// </summary>
        [RegularExpression(RegexPattern.STRING_SIX_DIGITS_BEFORE_DECIMAL_POINT)]
        public string? CleanWeight5 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public required decimal VMBMinimum { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public required decimal VMBMaximum { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal FactorWoolBase { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal FactorVMB { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal FactorHardHeadsBase { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_SIX_DIGITS)]
        public string? FactorAirflowMean { get; set; }

        [Required]
        public required CombinationFlag CombinationFlag { get; set; }
    }
}
