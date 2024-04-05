using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class CombinationDetails
    {
        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        [Required]
        public required int CleanWeight1 { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        public int? CleanWeight2 { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        public int? CleanWeight3 { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        public int? CleanWeight4 { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        public int? CleanWeight5 { get; set; }

        /// <summary>
        /// VMB - Minimum value.
        /// </summary>        
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? VmbMinimum { get; set; }

        /// <summary>
        /// VMB - Maximum value.
        /// </summary>        
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? VmbMaximum { get; set; }

        /// <summary>
        /// Factor for Wool Base.
        /// </summary>        
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? FactorWoolBase { get; set; }

        /// <summary>
        /// Factor for VMB.
        /// </summary>        
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? FactorVMB { get; set; }

        /// <summary>
        /// Factor for Hard Heads Base.
        /// </summary>        
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? FactorHardHeadsBase { get; set; }

        /// <summary>
        /// Factor for Airflow Mean. Factor used in combination calculation.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_SIX_DIGITS)]
        public double? FactorAirflowMean { get; set; }

        [Required]
        public CombinationFlag? CombinationFlag { get; set; }
    }
}
