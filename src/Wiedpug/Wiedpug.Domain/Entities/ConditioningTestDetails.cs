﻿using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class ConditioningTestDetails
    {
        [Required]
        [StringLength(11)]
        public required string CertificateIdentity { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_6_2)]
        public required double Charge { get; set; }

        [Required]
        [StringLength(1)]
        public required string Laboratory { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? RegrabSampleWeight { get; set; }

        [Required]
        [StringLength(1)]
        public required RetestFlag RetestFlag { get; set; }

        [Required]
        [StringLength(1)]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_6_1)]
        public double? MassOfGlobalSample { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_6_2)]
        public double? SumOfODMasses { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required int GainLossOfInvoiceMass { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public required double MoistureContent { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public required double Regain { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required int NetWeightODOfConsignment { get; set; }

        [Required]
        [StringLength (2)]
        public required YieldType YieldType { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required int OfficialRegain { get; set; }

        [Required]
        [StringLength (1)]
        public required InvoiceMassFlag InvoiceMassFlag { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        public required string DateIssued { get; set; }
    }
}
