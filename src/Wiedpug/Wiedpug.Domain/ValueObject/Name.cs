using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.ValueObject
{
    public class Name
    {
        [MinLength(1)]
        [MaxLength(80)]
        public string? FirstName { get; set; }

        [MinLength(1)]
        [MaxLength(80)]
        public string? LastName { get; set; }

        [MinLength(1)]
        [MaxLength(80)]
        public string? OrganisationName { get; set; }
    }
}
