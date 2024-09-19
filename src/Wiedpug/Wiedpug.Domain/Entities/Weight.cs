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
        [Range(-999999.99,999999.99)]
        public required double Value { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(9)]
        public required WeightCode WeightCode { get; set; }
    }
}
