using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.ValueObject
{
    public class PhoneNumber
    {
        [Required]
        public required string CountryCode { get; set; }

        [Required]
        public required string Number { get; set; }

    }
}
