﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class ScouredTestDetails
    {
        [Required]
        public required string CertificateIdentity { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double Charge { get; set; }

        [Required]
        public required string Laboratory { get; set; }

        public int? RegrabSampleWeight { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? WoolBase { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? AirflowMean { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double VMB { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double HardHeadsBase { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required string Yield1 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public string? Yield2 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public string? Yield3 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public string? Yield4 { get; set; }

        public YieldType? YieldType1 { get; set; }

        public YieldType? YieldType2 { get; set; }

        [Required]
        public required RetestFlag RetestFlag { get; set; }

        [Required]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public string? VM1 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public string? VM2 { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public string? VM3 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double AshContentDryBasis { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double  AlcoholExtractableMatterDryBasis { get; set; }
    }
}