﻿using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class TestCertificateOMLDetails
    {
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_6_2)]
        public required double Charge { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required Laboratory Laboratory { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? RegrabSampleWeight { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public required double WoolBase { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? AirflowMean { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public required double Vmb { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public required double HardHeadsBase { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public required double Yield1 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public double? Yield2 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public double? Yield3 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public double? Yield4 { get; set; }

        [MinLength(1)]
        [MaxLength(2)]
        public YieldType? YieldType1 { get; set; }

        [MinLength(1)]
        [MaxLength(2)]
        public YieldType? YieldType2 { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public RetestFlag? RetestFlag { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public double? Yield5 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? Vm1 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? Vm2 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? Vm3 { get; set; }        
    }
}
