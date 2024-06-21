using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class PostSaleCoreTestDetails
    {
        [Required]
        [StringLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_6_2)]
        public required double Charge { get; set; }

        [Required]
        [StringLength(1)]
        public required string Laboratory { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? RegrabSampleWeight { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public double? WoolBase { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? AirflowMean { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double VMB { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double HardHeadsBase { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public required double Yield1 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public double? Yield2 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public double? Yield3 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public double? Yield4 { get; set; }

        [StringLength(2)]
        public YieldType? YieldType1 { get; set; }

        [StringLength(2)]
        public YieldType? YieldType2 { get; set; }

        [Required]
        [StringLength(1)]
        public required RetestFlag RetestFlag { get; set; }

        [Required]
        [StringLength(1)]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? VM1 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? VM2 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? VM3 { get; set; }
    }
}
