using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class FiberDiameterHistogramHeader
    {
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public required double CoefficientOfVariation { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public required double ComfortFactor { get; set; }

        [RegularExpression(RegexPattern.STRING_SIX_DIGITS_BEFORE_DECIMAL_POINT)]
        public string? FibresMeasured { get; set; }

        [Required]
        public required ReportingFlag ReportingFlag { get; set; }

        [Required]
        public required Instrument Instrument { get; set; }

        [Required]
        public required SubsamplingMethod SubsamplingMethod { get; set; }

        [Required]
        public required int NumberOfSpecimens { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public required double Mean { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public required double StandardDeviation { get; set; }

        public int? CurvatureMean { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? MeanMinimum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? MeanMaximum { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public string? CoreTestSamplingDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string DateIssued { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_SIX_DIGITS)]
        public double? FactorLaserscanNumerator { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_SIX_DIGITS)]
        public double? FactorLaserscanDenominator { get; set; }
    }
}
