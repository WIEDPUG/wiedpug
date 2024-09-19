using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class BaleDetail
    {
        /// <summary>
        /// The number used to identify a bale in a lot
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required string BaleNumber { get; set; }

        /// <summary>
        /// Type of bale details, can be Renumbers, GreasyOrProcessesd, or Tripacks
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public required BaleDetailType BaleDetailType { get; set; }

        /// <summary>
        /// Property for Greasy/Processed bale detail, not necessary for other types of bale details.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(1)]
        public string? ShowBaleIndicator { get; set; }

        /// <summary>
        /// Property for Renumber BaleDetail, not necessary for other types of bale details.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(5)]
        public string? BaleRenumber { get; set; }

        /// <summary>
        /// Property for Tripacks BaleDetail, not necessary for other types of bale details.
        /// </summary>
        [Range(-99999,99999)]
        public int? UnitNumber { get; set; }

        /// <summary>
        /// Total weight of the wool. In transmissions from Test Houses, Gross 
        /// includes Regrab Sample Weight. In all other transmissions, Regrab 
        /// Sample Weight will have been subtracted from the Gross of a lot or a 
        /// group before the transmission. See the chapter ‘Business Rules’ for a 
        /// fuller explanation.
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? Gross { get; set; }

        /// <summary>
        /// The weight of the bale packaging
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? Tare { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        public string? EBaleId { get; set; }

        /// <summary>
        /// The number of tripacks (3 bales) in the lot.
        ///
        /// Property for Tripacks BaleDetail, not necessary for other types of bale details.
        /// </summary>
        [Range(-99,99)]
        public int? ThreeBaleCount { get; set; }

        /// <summary>
        /// The number of two bale tri-packs.
        ///
        /// Property for Tripacks BaleDetail, not necessary for other types of bale details.
        /// </summary>
        [Range(-99,99)]
        public int? TwoBaleCount { get; set; }
    }
}
