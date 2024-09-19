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

        [MinLength(1)]
        [MaxLength(10)]
        public required string ConsignmentReference { get; set; }

        [MinLength(1)]
        [MaxLength(10)]
        public string? SubConsignmentReference { get; set; }

        /// <summary>
        /// This number is provided be the Australian Custom Service’s EXIT system to the exporter. 
        /// It is included only if it is available at the time the delivery order is produced.
        /// </summary>
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

        /// <summary>
        /// These codes are maintained by Australian Chamber of Shipping
        /// </summary>
        [MinLength(1)]
        [MaxLength(7)]
        public string? VesselCode { get; set; }

        [MinLength(1)]
        [MaxLength(6)]
        public string? VoyageCode { get; set; }

        /// <summary>
        /// The code that identifies the port at which the wool will be unloaded. A 
        /// recognised code should be used in this field. These codes are issued 
        /// and maintained by the Australian Chamber of Shipping (ACOS).
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public string? PortOfDischargeCode { get; set; }

        /// <summary>
        /// A recognised code should be used in this field. These codes are issued and maintained by the Australian Chamber of Shipping (ACOS).
        /// </sunnary>
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

        /// <summary>
        /// A recognised code should be used in this field. These codes are issued and maintained by the Australian Chamber of Shipping (ACOS).
        /// </sunnary>
        [MinLength(1)]
        [MaxLength(20)]
        public string? PortOfDischargeDescription { get; set; }

        /// <summary>
        /// A recognised code should be used in this field. These codes are issued and maintained by the Australian Chamber of Shipping (ACOS).
        /// </sunnary>
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
