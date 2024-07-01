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
    public class WeightNote
    {
        [Required]
        [StringLength(1)]
        public required string Prefix{ get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_7_DIGITS)]
        [StringLength(7)]
        public required string Suffix { get; set; }
    }
}
