using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class OrganizationDetail
    {
        [Required]
        public required string Id { get; set; }

        [Required]
        public required string OrganisationCode { get; set; }

        [Required]
        public required string NameOfOrganisation { get; set; }

        /// <summary>
        /// Date value in ISO 8601 standard. e.g. 2024-03-21 (year-month-day)
        /// </summary>        
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string DateLastUpdated { get; set; }

        [Required]
        public required string IndustryGroupID { get; set; }

        [Required]
        public required string TransmitterFlag { get; set; }

        public PhoneNumber? PhoneNumber { get; set; }

        [Required]
        public required string Abn { get; set; }
        public PhoneNumber? FaxNumber { get; set; }
        public List<Address>? Addresses { get; set; }
        public List<Contact>? Contacts { get; set; }
    }
}
