﻿using System.ComponentModel.DataAnnotations;
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
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required int CleanWeight1 { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public int? CleanWeight2 { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public int? CleanWeight3 { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public int? CleanWeight4 { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public int? CleanWeight5 { get; set; }

        /// <summary>
        /// VMB - Minimum value.
        /// </summary>        
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? VmbMinimum { get; set; }

        /// <summary>
        /// VMB - Maximum value.
        /// </summary>        
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? VmbMaximum { get; set; }

        /// <summary>
        /// Factor for Wool Base.
        /// </summary>        
        [RegularExpression(RegexPattern.DECIMAL_10_2)]
        public double? FactorWoolBase { get; set; }

        /// <summary>
        /// Factor for VMB.
        /// </summary>        
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        public double? FactorVMB { get; set; }

        /// <summary>
        /// Factor for Hard Heads Base.
        /// </summary>        
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        public double? FactorHardHeadsBase { get; set; }

        /// <summary>
        /// Factor for Airflow Mean. Factor used in combination calculation.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_12_6)]
        public double? FactorAirflowMean { get; set; }

        [Required]
        [StringLength(1)]
        public CombinationFlag? CombinationFlag { get; set; }
    }
}
