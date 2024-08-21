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
        [Required]
        public required CertificateType CertificateType { get; set; }

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
        ///
        /// From: The current value that the Sale Identity is to be changed from.
        ///
        /// To: The new value that the Sale Identity is to be changed to.
        ///
        /// SellingCentre/Type can be one of the following code:
        ///
        /// SellingCentre/Type (New Zealand):
        ///
        /// C: Christchurch; N: Napier.
        ///
        /// SellingCentre/Type (Australia):
        ///
        /// A: Adelaide; AU: Australia; B: Brisbane; F: Fremantle; G: Geelong; L: Launceston; M: Melbourne; N: Newcastle; R: Goulburn; S: Sydney; PS: Private Sales; T: Auctions Plus Sales.
        /// </summary>
        [MinLength(1)]
        [MaxLength(6)]
        public SaleIdentity? SaleIdentity { get; set; }

        /// <summary>
        /// This is a compound name for lot number and lot suffix, where the lot 
        /// number is 5 numeric characters and the lot suffix is 1 alphanumeric
        /// character.The suffix is used when a lot is broken up by the original lot
        /// number is retained; for example.If 2 bales of a 10-bale lot got wet and
        /// the 8 bales and the 2 bales are offered separately, one could have a
        /// suffix A and the other a suffix B.Where a suffix is not used, the lot
        /// number occupies the whole of the Lot Identity field and is right justified.
        ///
        /// From:
        ///
        /// The current value that the Lot Identity is to be changed from.
        /// 
        /// To:
        /// 
        /// The new value that the Lot Identity is to be changed to.
        /// </summary>
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
        /// A boolean value to indicate whether to print Team3-Hauteur
        ///
        /// true: print
        ///
        /// false: not print
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsPrintingTEAM3Hauteur { get; set; }

        /// <summary>
        /// A boolean value to indicate whether to commit the combination/OML request for processing
        ///
        /// true: Commit the combination/OML request for processing
        ///
        /// false: Do not commit the combination/OML for processing (request will be available via WOOLINK for viewing/committing)
        ///
        /// Note: For non-WOOLINK clients the request will be committed for processing regardless of this field.
        /// </summary>
        [MinLength(1)]
        [MaxLength(1)]
        public bool? CommitCombinationOrOmlForProcessing { get; set; }

        public List<CertificateRequestDetail>? CertificateRequestDetails { get; set; }
    }

}
