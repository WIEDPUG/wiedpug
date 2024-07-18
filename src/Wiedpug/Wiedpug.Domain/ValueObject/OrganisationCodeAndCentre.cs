using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.ValueObject
{
    public class OrganisationCodeAndCentre
    {
        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        public required string OrganisationCode { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required Centre Centre { get; set; }
    }
}
