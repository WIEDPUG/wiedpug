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
    /// <summary>
    /// The first character contains the Weight Note prefix, and the next seven characters contain the weight Note Suffix.
    /// </summary>
    public class WeightNote
    {
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required string Prefix{ get; set; }

        [Required]
        [Range(-9999999,9999999)]
        public required int Suffix { get; set; }
    }
}
