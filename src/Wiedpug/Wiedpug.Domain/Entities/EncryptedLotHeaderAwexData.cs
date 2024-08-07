﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Entities
{
    public class EncryptedLotHeaderAwexData
    {
        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public required string EncryptionKeyIdentifier { get; set; }

        /// <summary>
        /// The encrypted LotHeaderAwexData in string format based on base64 encoding.
        /// 
        /// The schema reference can be found here: #/components/schemas/LotHeaderAwexData.
        /// 
        /// Detailed schema in yaml format:
        /// 
        /// LotHeaderAwexData:
        /// 
        ///   type: object
        ///   
        ///   properties:
        ///   
        ///     awexId:
        ///     
        ///       maxLength: 20
        ///       
        ///       minLength: 1
        ///       
        ///       type: string
        ///       
        ///       description: AWEX-ID must conform to the current AWEX-ID code standard.
        ///       
        ///       nullable: true
        ///       
        ///     appraiserId:
        ///     
        ///       maxLength: 6
        ///       
        ///       minLength: 1
        ///       
        ///       type: string
        ///       
        ///       description: Contains the AWEX accredited appraiser ID for this lot.
        ///       
        ///       nullable: true
        ///       
        ///     classersRegisteredNumber:
        ///     
        ///       maxLength: 6
        ///       
        ///       minLength: 1
        ///       
        ///       type: string
        ///       
        ///       description: The AWEX stencil number of the classer or classing house responsible for the final classification of the wool before sale.
        ///       
        ///       nullable: true
        ///       
        ///     awexIdComment:
        ///     
        ///       maxLength: 14
        ///       
        ///       minLength: 1
        ///       
        ///       type: string
        ///       
        ///       description: This field provides for additional comments relating to the information contained in the `awexId` field.
        ///       
        ///       nullable: true
        ///       
        ///     awexIdAuditCode:
        ///     
        ///       maxLength: 10
        ///       
        ///       minLength: 1
        ///       
        ///       type: string
        ///       
        ///       description: Audit code used for verifying if `awexId` was issued by AWEX
        ///       
        ///       nullable: true
        /// </summary>
        [Required]
        public required string EncryptedLotHeaderAwexDataString { get; set; }

        public LotHeaderAwexData? LotHeaderAwexData { get; set; }
    }
}
