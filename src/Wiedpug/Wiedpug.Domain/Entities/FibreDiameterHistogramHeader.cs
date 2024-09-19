using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class FibreDiameterHistogramHeader
    {        
        [Required]
        [Range(-999.9,999.9)]
        public required double CoefficientOfVariation { get; set; } // FIELD NUMBER 3 - Co-efficient of Variation - Start: 3, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        /// <summary>
        /// Percentage of Fibres 30 Microns and under.
        /// </summary>
        [Required]
        [Range(-999.9,999.9)]
        public required double ComfortFactorPercentage { get; set; } // FIELD NUMBER 4 - Comfort Factor (%) - Start: 6, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        [Range(-999999,999999)]
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
        [Range(-9999,9999)]
        public required int NumberOfSpecimens { get; set; } // FIELD NUMBER 9 - No. Of Specimens - Start: 18, Size: 4, Data Type: N, Justification: R, Requirement Designator: M

        /// <summary>
        /// This is Laserscan Mean or OFDA Mean depending on the value of instrument
        /// </summary>
        [Required]
        [Range(-999.9,999.9)]
        public required double Mean { get; set; } // FIELD NUMBER 10 - Mean - Start: 22, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        [Required]
        [Range(-999.9,999.9)]
        public required double StandardDeviation { get; set; } // FIELD NUMBER 11 - Standard Deviation - Start: 25, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        [Range(-999,999)]
        public int? CurvatureMeanDegPerMm { get; set; } // FIELD NUMBER 12 - Curvature Mean (deg/mm) - Start: 28, Size: 3, Data Type: N, Justification: R, Requirement Designator: O        

        /// <summary>
        /// This is the Laserscan or OFDA Mean Minimum depending on the value of instrument.This field will contain spaces until 30/06/2000
        /// </summary>
        [Range(-999.9,999.9)]
        public double? MeanMinimum { get; set; } // FIELD NUMBER 14 - Mean Minimum - Start: 32, Size: 3, Data Type: D1, Justification: R, Requirement Designator: C

        /// <summary>
        /// This is the Laserscan or OFDA Mean Maximum depending on the value of instrument.This field will contain spaces until 30/06/2000
        /// </summary>
        [Range(-999.9,999.9)]
        public double? MeanMaximum { get; set; } // FIELD NUMBER 15 - Mean Maximum - Start: 35, Size: 3, Data Type: D1, Justification: R, Requirement Designator: C

        /// <summary>
        /// For records Fibre Diameter Histogram Header and Test Request Verification this is the date core test was sampled or date combination/OML was requested.
        /// 
        /// For the Lot Header this is the date the core test was sampled, the last date of weighing for untested wool or the date the Combination/OML was requested.
        /// 
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
        public UtcDate? CoreTestSamplingDate { get; set; } // FIELD NUMBER 16 - Core Test Sampling Date - Start: 38, Size: 6, Data Type: DATE, Justification: F, Requirement Designator: C

        /// The date the certificate was issued.
        /// 
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>
        [Required]
        public required UtcDate DateIssued { get; set; } // FIELD NUMBER 17 - Date Issued - Start: 44, Size: 6, Data Type: DATE, Justification: F, Requirement Designator: M

        /// <summary>
        /// Factor used in numerator to calculate Laserscan Mean Laserscan Mean = Factor Laserscan Numerator/Factor Laserscan Denominator
        /// </summary>
        [Range(-9999999999.999999,9999999999.999999)]
        public double? FactorLaserscanNumerator { get; set; } // FIELD NUMBER 18 - Factor – Laserscan Numerator - Start: 50, Size: 16, Data Type: D6, Justification: R, Requirement Designator: C

        /// <summary>
        /// Factor used in denominator to calculate Laserscan Mean Laserscan Mean = Factor Laserscan Numerator/Factor Laserscan Denominator
        /// </summary>
        [Range(-999999999.999999,999999999.999999)]
        public double? FactorLaserscanDenominator { get; set; } // FIELD NUMBER 19 - Factor – Laserscan Denominator - Start: 66, Size: 15, Data Type: D6, Justification: R, Requirement Designator: C

    }
}
