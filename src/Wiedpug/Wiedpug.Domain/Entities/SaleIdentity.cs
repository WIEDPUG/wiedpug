using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    /// <summary>
    /// A group field of SellingCentre/Type and Sale Number
    ///
    /// From: The current value that the Sale Identity is to be changed from.
    ///
    /// To: The new value that the Sale Identity is to be changed to.
    ///
    /// </summary>
    public class SaleIdentity
    {
        /// <summary>
        ///
        /// The following codes are reserved for current and historical open cry auction selling centres:
        ///
        /// SellingCentre/Type (New Zealand):
        ///
        /// C: Christchurch; 
        /// 
        /// N: Napier.
        /// 
        ///
        /// SellingCentre/Type (Australia):
        ///
        /// A: Adelaide; 
        /// 
        /// AU: Australia; 
        /// 
        /// B: Brisbane; 
        /// 
        /// F: Fremantle; 
        /// 
        /// G: Geelong; 
        /// 
        /// L: Launceston; 
        /// 
        /// M: Melbourne; 
        /// 
        /// N: Newcastle; 
        /// 
        /// R: Goulburn; 
        /// 
        /// S: Sydney.
        /// 
        /// 
        /// The following codes are allocated for alternative sale types:
        ///
        /// PS: Private Sales; 
        /// 
        /// T: Auctions Plus Sales.
        ///
        /// 
        /// Please contact the WIEDPUG Secretary for the latest list of reserved and allocated codes.
        /// 
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required string SellingCentreType { get; set; }

        [Required]
        [Range(-99,99)]
        public required int SaleNumber { get; set; }
    }
}