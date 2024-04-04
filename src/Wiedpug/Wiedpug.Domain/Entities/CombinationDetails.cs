using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class CombinationDetails
    {
        [Required]
        public required int CleanWeight1 { get; set; }

        public int? CleanWeight2 { get; set; }

        public int? CleanWeight3 { get; set; }

        public int? CleanWeight4 { get; set; }

        public int? CleanWeight5 { get; set; }

        /// <summary>
        /// VMB - Minimum value.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public required decimal VMBMinimum { get; set; }

        /// <summary>
        /// VMB - Maximum value.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public required decimal VMBMaximum { get; set; }

        /// <summary>
        /// Factor for Wool Base.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal FactorWoolBase { get; set; }

        /// <summary>
        /// Factor for VMB.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal FactorVMB { get; set; }

        /// <summary>
        /// Factor for Hard Heads Base.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal FactorHardHeadsBase { get; set; }

        /// <summary>
        /// Factor for Airflow Mean.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_SIX_DIGITS)]
        public decimal? FactorAirflowMean { get; set; }

        [Required]
        public required CombinationFlag CombinationFlag { get; set; }
    }
}
