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
        [StringLength(80)]
        public string? FirstName { get; set; }

        [StringLength(80)]
        public string? LastName { get; set; }

        [StringLength(80)]
        public string? OrganisationName { get; set; }
    }
}
