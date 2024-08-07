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
        /// 
        [RegularExpression(RegexPattern.NUMBER_5_DIGITS)]
        public int? UnitNumber { get; set; }

        [MinLength(4)]
        [MaxLength(9)]
        public Weight? Gross { get; set; }

        [MinLength(4)]
        [MaxLength(9)]
        public Weight? Tare { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        public string? EBaleId { get; set; }
    }
}
