using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.ValueObject
{
    public class BaleDetail
    {
        [Required]
        public required string BaleNumber { get; set; }

        [Required]
        public required BaleDetailType BaleDetailType { get; set; }

        /// <summary>
        /// Property for Greasy/Processed bale detail, not necessary for other types of bale details.
        /// </summary>
        public string? ShowBaleIndicator { get; set; }

        /// <summary>
        /// Property for Renumber BaleDetail, not necessary for other types of bale details.
        /// </summary>
        public string? BaleRenumber { get; set; }

        /// <summary>
        /// Property for Tripacks BaleDetail, not necessary for other types of bale details.
        /// </summary>
        public int? UnitNumber { get; set; }

        [Required]
        public required int Gross { get; set; }

        [Required]
        public required int Tare { get; set; }

        public List<BaleIdentification>? BaleIdentifications { get; set; }
    }
}
