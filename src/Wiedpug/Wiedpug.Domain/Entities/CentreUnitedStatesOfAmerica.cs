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
    public class CentreUnitedStatesOfAmerica
    {
        [Required]
        [StringLength(3)]
        public required CountryCode Country { get; set; } = CountryCode.US;

        [Required]
        [StringLength(2)]
        public required CentreCodeUnitedStatesOfAmerica CentreCode { get; set; }
    }
}
