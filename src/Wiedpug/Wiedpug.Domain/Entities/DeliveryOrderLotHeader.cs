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
        public required Organisation InvoicingOrganisation { get; set; }

        [Required]
        public required Organisation SellingOrganisation { get; set; }

        [Required]
        public required int Season { get; set; }

        [Required]
        public required string SaleIdentity { get; set; }

        public Centre? CentreStorage { get; set; }

        [Required]
        public required Organisation StorageOrganisation { get; set; }

        public string? StorageDescription { get; set; }

        [Required]
        public required string LotIdentityOrGroupName { get; set; }

        [Required]
        public required int Bales { get; set; }

        [Required]
        public required int Gross { get; set; }

        [Required]
        public required int Tare { get; set; }

        public int? RegrabSampleWeight { get; set; }

        [Required]
        public required int TotalBalesInLot { get; set; }

        [Required]
        public required PackType PackTypeOriginal { get; set; }

        [Required]
        public required PackType PackTypePreferred { get; set; }

        [Required]
        public required WoolState WoolState { get; set; }


        // Lot Detail



        public CertificateIdentity? CertificateIdentity { get; set; }

        public int? RenumbersFirstBaleNumber { get; set; }

        public string? SIM { get; set; }

        public string? BlendSequence { get; set; }

        public string? ClientCrossReference { get; set; }

        public string? LotCountermarkHeadmark { get; set; }

        [Required]
        public required PackMaterial PackMaterial { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public string? DateDeliveryRequired { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public string? DatePickup { get; set; }

    }

}
