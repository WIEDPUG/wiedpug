using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Aggregates.LotPriceAndBuyersAggregate;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Wiedpug.Domain.Entities
{
    public class TestDataHeader
    {
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation Client { get; set; }

        public Season? Season { get; set; }

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
        [MaxLength(4)]
        public SaleIdentity? SaleIdentity { get; set; }

        /// <summary>
        /// The centre (code) representing the location at which the wool is stored (relevant to the intended use of the document). For example, the
        /// Centre- Storage against a lot in the Catalogue is the location of the wool where the buyer would expect to take delivery.
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public Centre? CentreStorage { get; set; }

        /// <summary>
        /// It can be a Lot Identity or a Group Number.
        ///
        /// Lot Identity:
        ///
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
        ///
        /// Group Number:
        ///
        /// A code used to identify a group of lots.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(6)]
        public required string LotIdentityOrGroupNumber { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public WeightNote? WeightNote { get; set; }

        /// <summary>
        /// The identity given to the lot in the computer system by the owner of the wool.
        /// 
        /// Client’s Cross Reference is transmitted by the owner of the wool to a Test House when the owner either verifies a test request(in a type of
        /// TRV document) or requests the printing of a certificate(in a type TCR document). If it is included in the transmission to the Test House, the
        /// Test House will also include it in its transmission of the certificate.The owner of the wool will then be able to connect the transmitted certificate
        /// with the wool in its computer system.In a Test Request Verification document, the field must contain the weight note number of the lot.
        /// The value in this field is NOT printed on the certificate.It is the value in the Certificate Reference field that is printed on the certificate.
        /// </summary>
        [MinLength(1)]
        [MaxLength(8)]
        public string? ClientCrossReference { get; set; }

        [Required]
        public required NumberOfBales NumberOfBales { get; set; }

        /// <summary>
        /// Total weight of the wool. In transmissions from Test Houses, Gross 
        /// includes Regrab Sample Weight. In all other transmissions, Regrab 
        /// Sample Weight will have been subtracted from the Gross of a lot or a 
        /// group before the transmission. See the chapter ‘Business Rules’ for a 
        /// fuller explanation.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight Gross { get; set; }

        /// <summary>
        /// The weight of the bale packaging
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight Tare { get; set; }

        /// <summary>
        /// The weight of a regrab sample, a grab sample taken after the wool has been initially sampled and tested, is shown on the new certificate.
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; }

        [MinLength(1)]
        [MaxLength(2)]
        public MulesingStatus? MulesingStatus { get; set; }

        /// <summary>
        /// The gross weight of the lot as declared by the owner
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? DeclaredGross { get; set; }

        /// <summary>
        /// The tare weight of the lot as declared by the owner
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? DeclaredTare { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public LotType LotType { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public Centre? CentreAuction { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public SourceCode? SourceCode { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public ReportingFlag? ReportingFlag { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public ScouredType? ScouredType { get; set; }

        /// <summary>
        /// A GST Amount with 2 digits after the decimal point
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? GSTAmount { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the GST is aplicable.
        /// 
        /// true: applicable.
        /// 
        /// false: not applicable.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsGstApplicable { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the Company ABN is applicable to invoice. 
        /// 
        /// true: applicable.
        /// 
        /// false: not applicable.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsCompanyAbnApplicable { get; set; }
    }
}
