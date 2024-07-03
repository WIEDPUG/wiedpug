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
        [StringLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        /// <summary>
        /// Required generic string field for weight note.
        /// </summary>
        [Required]
        [StringLength(8)]
        public required WeightNote WeightNote { get; set; }

        /// <summary>
        /// Required alphanumeric field for lot identity.
        /// </summary>
        [Required]
        [StringLength(6)]
        public required string LotIdentity { get; set; }

        /// <summary>
        /// Required generic string field for buying organisation.
        /// </summary>
        [Required]
        [StringLength(5)]
        public required Organisation BuyingOrganisation { get; set; }

        /// <summary>
        /// Required enum type for sale outcome.
        /// </summary>
        [Required]
        [StringLength(1)]
        public required SaleOutcome SaleOutcome { get; set; }

        /// <summary>
        /// Required numeric field for bales.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        [StringLength(3)]
        public required int Bales { get; set; }

        /// <summary>
        /// Required numeric field for gross weight.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_5_DIGITS)]
        [StringLength(5)]
        public required int Gross { get; set; }

        /// <summary>
        /// Required generic string field for sale identity.
        /// </summary>
        [Required]
        [StringLength(4)]
        public required SaleIdentity SaleIdentity { get; set; }

        /// <summary>
        /// Required enum type for centre-storage.
        /// </summary>
        [Required]
        [StringLength(5)]
        public required Centre CentreStorage { get; set; }

        /// <summary>
        /// Required enum type for certificate delivery indicator.
        /// </summary>
        [Required]
        [StringLength(1)]
        public required CertificateDeliveryIndicator CertificateDeliveryIndicator { get; set; }

        /// <summary>
        /// Optional numeric field for cost per weight unit.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        [StringLength(6)]
        public int? CostPerWeightUnit { get; set; }

        /// <summary>
        /// Optional enum type for print flag.
        /// </summary>
        /// 
        [StringLength(1)]
        public PrintFlag? PrintFlag { get; set; }

        /// <summary>
        /// Bool value for TEAM-3 Hauteur - Print.
        /// True: Print TEAM-3 Hauteur on Certificate
        /// False: Not print TEAM-3 Hauteur on Certificate
        /// </summary>
        /// 
        [StringLength(5)]
        public bool? PrintTEAM3HauteurOnCertificate { get; set; }

        /// <summary>
        /// Optional enum type for WOOLINK sale system.
        /// </summary>
        /// 
        [StringLength(1)]
        public WoolinkSaleSystem? WoolinkSaleSystem { get; set; }

        /// <summary>
        /// Optional enum type for sale type.
        /// </summary>
        /// 
        [StringLength(2)]
        public SaleType? SaleType { get; set; }
    }


}
