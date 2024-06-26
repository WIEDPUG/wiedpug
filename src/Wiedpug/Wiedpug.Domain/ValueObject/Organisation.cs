using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.ValueObject
{
    public class Organisation
    {
        [StringLength(8)]
        public OrganisationAndCentre? OrganisationAndCentre { get; set; }

        [StringLength(5)]
        public string? OrganisationCode { get; set; }
    }
}
