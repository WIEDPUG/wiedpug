using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class OrganisationDetail
    {
        public string? Id { get; set; }

        [Required]
        [StringLength(5)]
        public required string OrganisationCode { get; set; }

        [Required]
        [StringLength(50)]
        public required string NameOfOrganisation { get; set; }

        /// <summary>
        /// Date value in IS standard. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>        
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [StringLength(6)]
        public required string DateLastUpdated { get; set; }

        [Required]
        [StringLength(1)]
        public required string IndustryGroupId { get; set; }

        [Required]
        [StringLength(1)]
        public required string TransmitterFlag { get; set; }

        public PhoneNumber? PhoneNumber { get; set; }

        /// <summary>
        /// Australian Business Number
        /// </summary>
        [StringLength(11)]
        [RegularExpression(Regex.NUMBERS)]
        public string? ABN { get; set; }

        public PhoneNumber? FaxNumber { get; set; }

        public List<Address>? Addresses { get; set; }

        public List<Contact>? Contacts { get; set; }
    }
}
