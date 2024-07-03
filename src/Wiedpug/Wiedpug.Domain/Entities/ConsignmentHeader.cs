using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class ConsignmentHeader
    {
        [Required]
        [RegularExpression(RegexPattern.NUMBER_10_DIGITS)]
        [StringLength(10)]
        public required string ConsignmentReference { get; set; }

        [StringLength(10)]
        public string? SubConsignmentReference { get; set; }

        [StringLength(14)]
        public string? EcnCrn { get; set; }

        [StringLength(8)]
        public Organisation? ShippingAgent { get; set; }

        [StringLength(8)]
        public Organisation? ShoreServiceProvider { get; set; }

        [StringLength(8)]
        public Organisation? DumpingOrganisation { get; set; }

        [StringLength(7)]
        public string? VesselCode { get; set; }

        [StringLength(6)]
        public string? VoyageCode { get; set; }

        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }

        [StringLength(5)]
        public string? LoadPortCode { get; set; }

        [Required]
        [StringLength(8)]
        public required Organisation Shipper { get; set; }


        [StringLength(30)]
        public string? VesselDescription { get; set; }

        [StringLength(20)]
        public string? LoadPortDescription { get; set; }

        [StringLength(20)]
        public string? PortOfDischargeDescription { get; set; }

        [StringLength(5)]
        public string? AlternatePortOfDischargeCode { get; set; }

        [StringLength(30)]
        public string? AlternatePortOfDischargeDescription { get; set; }

        [StringLength(30)]
        public string? BookingReference { get; set; }


    }

}
