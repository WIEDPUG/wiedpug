using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Entities
{
    public class LotHeaderAwexData
    {
        /// <summary>
        /// AWEX-ID must conform to the current AWEX-ID code standard.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(20)]
        public string? AwexId { get; set; } 

        /// <summary>
        /// Contains the AWEX accredited appraiser ID for this lot.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(6)]
        public string? AppraiserId { get; set; }

        /// <summary>
        /// The AWEX stencil number of the classer or classing house responsible for the final classification of the wool before sale.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(6)]
        public string? ClassersRegisteredNumber { get; set; } 

        /// <summary>
        /// This field provides for additional comments relating to the information contained in the awexId field.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(14)]
        public string? AwexIdComment { get; set; } 
        /// <summary>
        /// Audit code used for verifying if awexId was issued by AWEX
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(10)]
        public string? AwexIdAuditCode { get; set; }

    }
}
