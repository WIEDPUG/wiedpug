using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class BaleDetail
    {
        [Required]
        [StringLength(5)]
        public required string BaleNumber { get; set; }

        /// <summary>
        /// Type of bale details, can be Renumbers, GreasyOrProcessesd, or Tripacks
        /// </summary>
        [Required]
        [StringLength(20)]
        public required BaleDetailType BaleDetailType { get; set; }

        /// <summary>
        /// Property for Greasy/Processed bale detail, not necessary for other types of bale details.
        /// </summary>
        /// 
        [StringLength(1)]
        public string? ShowBaleIndicator { get; set; }

        /// <summary>
        /// Property for Renumber BaleDetail, not necessary for other types of bale details.
        /// </summary>
        /// 
        [StringLength(5)]
        public string? BaleRenumber { get; set; }

        /// <summary>
        /// Property for Tripacks BaleDetail, not necessary for other types of bale details.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_5_DIGITS)]
        public int? UnitNumber { get; set; }

        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public int? Gross { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? Tare { get; set; }

        public List<BaleIdentification>? BaleIdentifications { get; set; }
    }
}
