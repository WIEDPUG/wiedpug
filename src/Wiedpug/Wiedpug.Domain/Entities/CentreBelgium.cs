using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class CentreBelgium
    {
        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        public required CountryCode Country { get; set; } = CountryCode.BE;

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required CentreCodeBelgium CentreCode { get; set; }
    }
}
