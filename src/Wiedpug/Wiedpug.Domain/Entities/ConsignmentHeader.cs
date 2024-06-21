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
        public required string ConsignmentReference { get; set; }

        public string? SubConsignmentReference { get; set; }

        public string? EcnCrn { get; set; }

        public Organisation? ShippingAgent { get; set; }

        public Organisation? ShoreServiceProvider { get; set; }

        public Organisation? DumpingOrganisation { get; set; }

        public string? VesselCode { get; set; }

        public string? VoyageCode { get; set; }

        public string? PortOfDischargeCode { get; set; }

        public string? LoadPortCode { get; set; }

        [Required]
        public required Organisation Shipper { get; set; }



        public string? VesselDescription { get; set; }

        public string? LoadPortDescription { get; set; }

        public string? PortOfDischargeDescription { get; set; }

        public string? AlternatePortOfDischargeCode { get; set; }

        public string? AlternatePortOfDischargeDescription { get; set; }

        public string? BookingReference { get; set; }


    }

}
