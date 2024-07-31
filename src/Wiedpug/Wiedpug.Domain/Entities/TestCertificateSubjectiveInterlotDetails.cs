﻿using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class TestCertificateSubjectiveInterlotDetails
    {
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency Charge { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required Laboratory Laboratory { get; set; }

        /// <summary>
        /// The weight of a regrab sample, a grab sample taken after the wool has been initially sampled and tested, is shown on the new certificate.
        /// </summary>
        /// 
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; }

        /// <summary>
        /// The oven-dry mass of wool fibre free from all impurities, expressed as a percentage of the mass of the sample. 
        /// Min - The lowest value in a range of Wool Base values. 
        /// Max - The highest value in a range of Wool Base values.
        /// </summary>
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

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required RetestFlag RetestFlag { get; set; }

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

        [MinLength(1)]
        [MaxLength(1)]
        public string? DarkAndMedullatedFibreRisk { get; set; }
    }
}