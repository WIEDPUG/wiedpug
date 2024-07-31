using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class Weight
    {
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_8_2)]
        public required double Value { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required WeightUnit Unit { get; set; }
    }
}
