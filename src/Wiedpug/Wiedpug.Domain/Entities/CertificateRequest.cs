using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class CertificateRequest
    {
        public PrintRequirements? PrintRequirements { get; set; }

        public YieldType? YieldType1 { get; set; }

        public YieldType? YieldType2 { get; set; }

        public string? CertificateReference { get; set; }

        public string? ClientsCrossReference { get; set; }

        public int? DeclaredGross { get; set; }
        
        public int? DeclaredTare { get; set; }

        public int? SampleWeightRemoved { get; set; }

        [Required]
        public required int Bales { get; set; }

        public int? Season { get; set; }

        public string? SaleIdentity { get; set; }

        public string? LotIdentity { get; set; }

        public PrintFlag? PrintFlag { get; set; }

        public CombinationRequest? CombinationRequest { get; set; }

        public AutoAdditionalMeasurementRequired? AutoAdditionalMeasurementRequired { get; set; }

        public AdditionalPrintRequirements? AdditionalPrintRequirements { get; set; }

        public bool? TEAM3HauteurPrint { get; set; }

        public string? CommitType { get; set; }

        public BaleHeader? BaleHeader { get; set; }

        public List<CertificateRequestDetail>? CertificateRequestDetails { get; set; }
    }

}
