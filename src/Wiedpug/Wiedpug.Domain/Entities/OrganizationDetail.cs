using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class OrganizationDetail
    {
        public required string Id { get; set; }
        public string OrganisationCode { get; set; }
        public string NameOfOrganisation { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string IndustryGroupID { get; set; }
        public string TransmitterFlag { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public string ABN { get; set; }
        public PhoneNumber FaxNumber { get; set; }
        public Address[] Addresses { get; set; }
        public Contact[] Contacts { get; set; }
    }
}
