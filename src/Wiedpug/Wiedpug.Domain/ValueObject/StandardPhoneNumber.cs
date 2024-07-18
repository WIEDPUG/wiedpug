using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class StandardPhoneNumber
    {
        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        [RegularExpression(RegexPattern.NUMBERS)]
        public required string CountryCode { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBERS)]
        [MinLength(1)]
        [MaxLength(15)]
        public required string Number { get; set; }
    }
}
