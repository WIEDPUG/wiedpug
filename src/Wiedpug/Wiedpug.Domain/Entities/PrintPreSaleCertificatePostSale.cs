using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class PrintPreSaleCertificatePostSale
    {
        /// <summary>
        /// Required generic string field for certificate identity.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        /// <summary>
        /// Required generic string field for weight note.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required WeightNote WeightNote { get; set; }

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
        [Required]
        [MinLength(1)]
        [MaxLength(6)]
        public required string LotIdentity { get; set; }

        /// <summary>
        /// Required generic string field for buying organisation.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required Organisation BuyingOrganisation { get; set; }

        /// <summary>
        /// Required enum type for sale outcome.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required SaleOutcome SaleOutcome { get; set; }

        /// <summary>
        /// Number of bales
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        [MinLength(1)]
        [MaxLength(3)]
        public required int NumberOfBales { get; set; }

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
        [Required]
        [MinLength(1)]
        [MaxLength(4)]
        public required SaleIdentity SaleIdentity { get; set; }

        /// <summary>
        /// The centre (code) representing the location at which the wool is stored (relevant to the intended use of the document). For example, the
        /// Centre- Storage against a lot in the Catalogue is the location of the wool where the buyer would expect to take delivery.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required Centre CentreStorage { get; set; }

        /// <summary>
        /// Required enum type for certificate delivery indicator.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required CertificateDeliveryIndicator CertificateDeliveryIndicator { get; set; }

        /// <summary>
        /// The selling price per weight unit. Generally, cost per weight unit will be in Australian cents per kilogram.
        /// </summary>
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        [MinLength(1)]
        [MaxLength(6)]
        public int? CostPerWeightUnit { get; set; }

        /// <summary>
        /// Optional enum type for print flag.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(1)]
        public PrintFlag? PrintFlag { get; set; }

        /// <summary>
        /// A boolean value to indicate whether to print Team3-Hauteur.
        /// 
        /// true: print.
        /// 
        /// false: not print.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsPrintingPrintTEAM3Hauteur { get; set; }

        /// <summary>
        /// Optional enum type for WOOLINK sale system.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(1)]
        public WoolinkSaleSystem? WoolinkSaleSystem { get; set; }

        /// <summary>
        /// Optional enum type for sale type.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(2)]
        public SaleType? SaleType { get; set; }
    }


}
