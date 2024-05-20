using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.ValueObject
{
    public class Address
    {
        [StringLength(80)]
        public string? FirstName { get; set; }

        [StringLength(80)]
        public string? LastName { get; set; }

        [StringLength(80)]
        public string? OrganisationName { get; set; }

        [StringLength(80)]
        public string? Premise { get; set; }

        [StringLength(80)]
        public string? Street { get; set; }

        [StringLength(80)]
        public string? Suburb { get; set; }

        [StringLength(80)]
        public string? City { get; set; }

        [StringLength(80)]
        public string? RegionOrState { get; set; }

        [StringLength(80)]
        public string? PostCode { get; set; }

        [StringLength(80)]
        public string? Country { get; set; }
    }
}
