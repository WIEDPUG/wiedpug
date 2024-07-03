﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class CertificateRequest
    {
        [StringLength(1)]
        public PrintRequirements? PrintRequirements { get; set; }

        [StringLength(2)]
        public YieldType? YieldType1 { get; set; }

        [StringLength(2)]
        public YieldType? YieldType2 { get; set; }

        [StringLength(30)]
        public string? CertificateReference { get; set; }

        [StringLength(8)]
        public string? ClientsCrossReference { get; set; }

        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public int? DeclaredGross { get; set; }

        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public int? DeclaredTare { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? SampleWeightRemoved { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public required int Bales { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? Season { get; set; }

        [StringLength(4)]
        public SaleIdentity? SaleIdentity { get; set; }

        [StringLength(6)]
        public string? LotIdentity { get; set; }

        [StringLength(1)]
        public PrintFlag? PrintFlag { get; set; }

        [StringLength(1)]
        public CombinationRequest? CombinationRequest { get; set; }

        [StringLength(1)]
        public AutoAdditionalMeasurementRequired? AutoAdditionalMeasurementRequired { get; set; }

        [StringLength(1)]
        public AdditionalPrintRequirements? AdditionalPrintRequirements { get; set; }

        [StringLength(5)]
        public bool? TEAM3HauteurPrint { get; set; }

        [StringLength(1)]
        public string? CommitType { get; set; }

        public List<CertificateRequestDetail>? CertificateRequestDetails { get; set; }
    }

}
