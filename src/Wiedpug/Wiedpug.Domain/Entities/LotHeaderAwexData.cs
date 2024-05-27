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
        [StringLength(20)]
        public string? AwexId { get; set; } // FIELD NUMBER 3 - AWEX-ID - Start: 4, Size: 20, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// Contains the AWEX accredited appraiser ID for this lot.
        /// </summary>
        /// 
        [StringLength(6)]
        public string? AppraiserId { get; set; } // FIELD NUMBER 4 - Appraiser ID - Start: 24, Size: 6, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// The AWEX stencil number of the classer or classing house responsible for the final classification of the wool before sale.
        /// </summary>
        /// 
        [StringLength(6)]
        public string? ClassersRegisteredNumber { get; set; } // FIELD NUMBER 5 - Classer’s Registered Number - Start: 30, Size: 6, Data Type: AN, Justification: F, Requirement Designator: C

        /// <summary>
        /// This field provides for additional comments relating to the information contained in the `awexId` field.
        /// </summary>
        /// 
        [StringLength(14)]
        public string? AwexIdComment { get; set; } // FIELD NUMBER 6 - AWEX-ID Comment - Start: 36, Size: 14, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// Audit code used for verifying if `awexId` was issued by AWEX
        /// </summary>
        /// 
        [StringLength(10)]
        public string? AwexIdAuditCode { get; set; } // FIELD NUMBER 7 - AWEX-ID Audit Code - Start: 50, Size: 10, Data Type: AN, Justification: L, Requirement Designator: O

    }
}
