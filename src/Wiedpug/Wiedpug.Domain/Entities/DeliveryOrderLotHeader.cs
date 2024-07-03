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
        [StringLength(8)]
        public required Organisation InvoicingOrganisation { get; set; }

        [Required]
        [StringLength(8)]
        public required Organisation SellingOrganisation { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int Season { get; set; }

        [Required]
        [StringLength(4)]
        public required SaleIdentity SaleIdentity { get; set; }

        [StringLength(5)]
        public Centre? CentreStorage { get; set; }

        [Required]
        [StringLength(5)]
        public required Organisation StorageOrganisation { get; set; }

        [StringLength(15)]
        public string? StorageDescription { get; set; }

        [Required]
        [StringLength(6)]
        public required LotIdentityOrGroupName LotIdentityOrGroupName { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        [StringLength(4)]
        public required int Bales { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        [StringLength(6)]
        public required int Gross { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        [StringLength(4)]
        public required int Tare { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        [StringLength(2)]
        public int? RegrabSampleWeight { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        [StringLength(4)]
        public required int TotalBalesInLot { get; set; }

        [Required]
        [StringLength(1)]
        public required PackType PackTypeOriginal { get; set; }

        [Required]
        [StringLength(1)]
        public required PackType PackTypePreferred { get; set; }

        [Required]
        [StringLength(1)]
        public required WoolState WoolState { get; set; }


        // Lot Detail


        [StringLength(11)]
        public CertificateIdentity? CertificateIdentity { get; set; }

        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        [StringLength(6)]
        public int? RenumbersFirstBaleNumber { get; set; }

        [StringLength(10)]
        public string? SIM { get; set; }

        [StringLength(2)]
        public string? BlendSequence { get; set; }

        [StringLength(8)]
        public string? ClientCrossReference { get; set; }

        [StringLength(10)]
        public string? LotCountermarkHeadmark { get; set; }

        [Required]
        [StringLength(2)]
        public required PackMaterial PackMaterial { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [StringLength(10)]
        public string? DateDeliveryRequired { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [StringLength(10)]
        public string? DatePickup { get; set; }

    }

}
