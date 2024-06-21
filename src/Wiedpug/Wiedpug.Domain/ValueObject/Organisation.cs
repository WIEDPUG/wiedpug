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
        public OrganisationAndCentre? OrganizationAndCentre { get; set; }

        [StringLength(5)]
        public string? OrganizationCode { get; set; }
    }
}
