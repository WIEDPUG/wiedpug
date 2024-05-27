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
        [StringLength(3)]
        [RegularExpression(RegexPattern.NUMBERS)]
        public required string CountryCode { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBERS)]
        [StringLength(15)]
        public required string Number { get; set; }
    }
}
