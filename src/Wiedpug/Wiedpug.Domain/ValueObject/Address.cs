using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.ValueObject
{
    public class Address
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? OrganizationName { get; set; }
        public string? Premise { get; set; }
        public string? Street { get; set; }
        public string? Suburb { get; set; }
        public string? City { get; set; }
        public string? RegionOrState { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
    }
}
