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
        /// Required alphanumeric field for lot identity.
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
        /// Required numeric field for bales.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        [MinLength(1)]
        [MaxLength(3)]
        public required int Bales { get; set; }

        /// <summary>
        /// Required numeric field for gross weight.
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
        /// Required enum type for centre-storage.
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
        /// Optional numeric field for cost per weight unit.
        /// </summary>
        /// 
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
