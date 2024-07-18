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
        [MinLength(1)]
        [MaxLength(10)]
        public required string ConsignmentReference { get; set; }

        [MinLength(1)]
        [MaxLength(10)]
        public string? SubConsignmentReference { get; set; }

        [MinLength(1)]
        [MaxLength(14)]
        public string? EcnCrn { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public Organisation? ShippingAgent { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public Organisation? ShoreServiceProvider { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public Organisation? DumpingOrganisation { get; set; }

        [MinLength(1)]
        [MaxLength(7)]
        public string? VesselCode { get; set; }

        [MinLength(1)]
        [MaxLength(6)]
        public string? VoyageCode { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public string? PortOfDischargeCode { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public string? LoadPortCode { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation Shipper { get; set; }


        [MinLength(1)]
        [MaxLength(30)]
        public string? VesselDescription { get; set; }

        [MinLength(1)]
        [MaxLength(20)]
        public string? LoadPortDescription { get; set; }

        [MinLength(1)]
        [MaxLength(20)]
        public string? PortOfDischargeDescription { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public string? AlternatePortOfDischargeCode { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        public string? AlternatePortOfDischargeDescription { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        public string? BookingReference { get; set; }


    }

}
