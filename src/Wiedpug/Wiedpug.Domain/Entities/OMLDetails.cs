using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class OMLDetails
    {
        [Required]
        public required string CertificateIdentity { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? Charge { get; set; }

        [Required]
        public required Laboratory Laboratory { get; set; }

        public int? RegrabSampleWeight { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double WoolBase { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? AirflowMean { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public required double Vmb { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public required double HardHeadsBase { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double Yield1 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? Yield2 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? Yield3 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? Yield4 { get; set; }

        public YieldType? YieldType1 { get; set; }

        public YieldType? YieldType2 { get; set; }

        [Required]
        public required RetestFlag RetestFlag { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? Yield5 { get; set; }

        [Required]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? Vm1 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? Vm2 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? Vm3 { get; set; }        
    }
}
