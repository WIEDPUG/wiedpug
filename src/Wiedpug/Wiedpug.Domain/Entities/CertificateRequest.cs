using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class CertificateRequest
    {
        [MinLength(1)]
        [MaxLength(1)]
        public PrintRequirements? PrintRequirements { get; set; }

        [MinLength(1)]
        [MaxLength(2)]
        public YieldType? YieldType1 { get; set; }

        [MinLength(1)]
        [MaxLength(2)]
        public YieldType? YieldType2 { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        public string? CertificateReference { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public string? ClientsCrossReference { get; set; }

        [MinLength(4)]
        [MaxLength(9)]
        public Weight? DeclaredGross { get; set; }

        [MinLength(4)]
        [MaxLength(9)]
        public Weight? DeclaredTare { get; set; }

        [MinLength(4)]
        [MaxLength(9)]
        public Weight? SampleWeightRemoved { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public required int Bales { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? Season { get; set; }

        /// <summary>
        /// A group field of SellingCentre/Type and Sale Number
        /// From: The current value that the Sale Identity is to be changed from.
        /// To: The new value that the Sale Identity is to be changed to.
        /// SellingCentre/Type can be one of the following code:
        /// NZ_C: Christchurch; NZ_N: Napier; AU_A: Adelaide; AU: Australia; AU_B: Brisbane; AU_F: Fremantle; AU_G: Geelong;
        /// AU_L: Launceston; AU_M: Melbourne; AU_N: Newcastle; AU_R: Goulburn; AU_S: Sydney; PS: Private Sales; T: Auctions Plus Sales.
        /// </summary>
        [MinLength(1)]
        [MaxLength(6)]
        public string? SaleIdentity { get; set; }

        [MinLength(1)]
        [MaxLength(6)]
        public string? LotIdentity { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public PrintFlag? PrintFlag { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public CombinationRequest? CombinationRequest { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public AutoAdditionalMeasurementRequired? AutoAdditionalMeasurementRequired { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public AdditionalPrintRequirements? AdditionalPrintRequirements { get; set; }

        /// <summary>
        /// A boolean value to indicate whethear to print Team3-Hauteur
        /// true: print
        /// false: not print
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsPrintingTEAM3Hauteur { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public string? CommitType { get; set; }

        public List<CertificateRequestDetail>? CertificateRequestDetails { get; set; }
    }

}
