using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class CombinationDetail
    {
        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        [Required]
        public required Weight CleanWeight1 { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        /// 
        public Weight? CleanWeight2 { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        /// 
        public Weight? CleanWeight3 { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        /// 
        public Weight? CleanWeight4 { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        /// 
        public Weight? CleanWeight5 { get; set; }

        /// <summary>
        /// Vegetable Matter Base. The oven dry mass of ash-free, ethyl alcohol extractives - free burrs (including hardheads), twigs, seeds, leaves 
        /// and grasses present, expressed as a percentage of the mass of the greasy core sample.
        ///
        /// Average: The average value of vegetable matter base values for a number of lots.
        ///
        /// Minimum: The lowest value in a range of vegetable matter base values.
        ///
        /// Maximum: The highest value in a range of vegetable matter base values.
        /// </summary>        
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? VmbMinimum { get; set; }

        /// <summary>
        /// Vegetable Matter Base. The oven dry mass of ash-free, ethyl alcohol extractives - free burrs (including hardheads), twigs, seeds, leaves 
        /// and grasses present, expressed as a percentage of the mass of the greasy core sample.
        ///
        /// Average: The average value of vegetable matter base values for a number of lots.
        ///
        /// Minimum: The lowest value in a range of vegetable matter base values.
        ///
        /// Maximum: The highest value in a range of vegetable matter base values.
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
        public double? FactorVmb { get; set; }

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
        [MinLength(1)]
        [MaxLength(1)]
        public CombinationFlag? CombinationFlag { get; set; }
    }
}
