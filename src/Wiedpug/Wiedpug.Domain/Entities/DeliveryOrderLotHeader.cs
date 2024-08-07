using System;
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
    public class DeliveryOrderLotHeader
    {
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation InvoicingOrganisation { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation SellingOrganisation { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int Season { get; set; }

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
        public required string SaleIdentity { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public Centre? CentreStorage { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required Organisation StorageOrganisation { get; set; }

        [MinLength(1)]
        [MaxLength(15)]
        public string? StorageDescription { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(6)]
        public required LotIdentityOrGroupName LotIdentityOrGroupName { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        [MinLength(1)]
        [MaxLength(4)]
        public required int Bales { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight Gross { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight Tare { get; set; }

        [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        [MinLength(1)]
        [MaxLength(4)]
        public required int TotalBalesInLot { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required PackType PackTypeOriginal { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required PackType PackTypePreferred { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required WoolState WoolState { get; set; }


        // Lot Detail


        [MinLength(1)]
        [MaxLength(11)]
        public CertificateIdentity? CertificateIdentity { get; set; }

        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        [MinLength(1)]
        [MaxLength(6)]
        public int? RenumbersFirstBaleNumber { get; set; }

        [MinLength(1)]
        [MaxLength(10)]
        public string? SIM { get; set; }

        [MinLength(1)]
        [MaxLength(2)]
        public string? BlendSequence { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public string? ClientCrossReference { get; set; }

        [MinLength(1)]
        [MaxLength(10)]
        public string? LotCountermarkHeadmark { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required PackMaterial PackMaterial { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? DateDeliveryRequired { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? DatePickup { get; set; }

    }

}
