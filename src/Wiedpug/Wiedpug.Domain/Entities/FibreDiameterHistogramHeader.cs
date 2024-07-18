using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class FibreDiameterHistogramHeader
    {        
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public required double CoefficientOfVariation { get; set; } // FIELD NUMBER 3 - Co-efficient of Variation - Start: 3, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        /// <summary>
        /// Percentage of Fibres 30 Microns and under.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public required double ComfortFactorPercentage { get; set; } // FIELD NUMBER 4 - Comfort Factor (%) - Start: 6, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public int? FibresMeasured { get; set; } // FIELD NUMBER 5 - Fibres Measured - Start: 9, Size: 6, Data Type: N, Justification: R, Requirement Designator: C

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required ReportingFlag ReportingFlag { get; set; } // FIELD NUMBER 6 - Reporting Flag - Start: 15, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required Instrument Instrument { get; set; } // FIELD NUMBER 7 - Instrument - Start: 16, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required SubSamplingMethod SubSamplingMethod { get; set; } // FIELD NUMBER 8 - Sub-sampling Method - Start: 17, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public required int NumberOfSpecimens { get; set; } // FIELD NUMBER 9 - No. Of Specimens - Start: 18, Size: 4, Data Type: N, Justification: R, Requirement Designator: M

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public required double Mean { get; set; } // FIELD NUMBER 10 - Mean - Start: 22, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public required double StandardDeviation { get; set; } // FIELD NUMBER 11 - Standard Deviation - Start: 25, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? CurvatureMeanDegPerMm { get; set; } // FIELD NUMBER 12 - Curvature Mean (deg/mm) - Start: 28, Size: 3, Data Type: N, Justification: R, Requirement Designator: O        

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? MeanMinimum { get; set; } // FIELD NUMBER 14 - Mean Minimum - Start: 32, Size: 3, Data Type: D1, Justification: R, Requirement Designator: C

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? MeanMaximum { get; set; } // FIELD NUMBER 15 - Mean Maximum - Start: 35, Size: 3, Data Type: D1, Justification: R, Requirement Designator: C

        /// <summary>
        /// For records 31 and 55 this is the date core test was sampled or date combination/OML was requested.
        /// For the 21A record this is the date the core test was sampled, the last date of weighing for untested wool or the date the Combination/OML was requested.        
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21. 
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? CoreTestSamplingDate { get; set; } // FIELD NUMBER 16 - Core Test Sampling Date - Start: 38, Size: 6, Data Type: DATE, Justification: F, Requirement Designator: C

        /// <summary>
        /// Date value in ISO 8601 standard UTC format. e.g. 2024-03-21. 
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string DateIssued { get; set; } // FIELD NUMBER 17 - Date Issued - Start: 44, Size: 6, Data Type: DATE, Justification: F, Requirement Designator: M

        [RegularExpression(RegexPattern.DECIMAL_16_6)]
        public double? FactorLaserscanNumerator { get; set; } // FIELD NUMBER 18 - Factor – Laserscan Numerator - Start: 50, Size: 16, Data Type: D6, Justification: R, Requirement Designator: C
        
        [RegularExpression(RegexPattern.DECIMAL_15_6)]
        public double? FactorLaserscanDenominator { get; set; } // FIELD NUMBER 19 - Factor – Laserscan Denominator - Start: 66, Size: 15, Data Type: D6, Justification: R, Requirement Designator: C

    }
}
