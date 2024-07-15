using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class OrganisationDetail
    {
        public string? Id { get; set; }

        [Required]
        [StringLength(8)]
        public required Organisation Organisation { get; set; }

        [Required]
        [StringLength(50)]
        public required string NameOfOrganisation { get; set; }

        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>        
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [StringLength(10)]
        public required string DateLastUpdated { get; set; }

        [Required]
        [StringLength(1)]
        public required IndustryGroupId IndustryGroupId { get; set; }

        /// <summary>
        /// A boolean value to determine wether the organisation transmits or receives data electronically.
        /// True for transmits or receives data electronically. False for not.
        /// </summary>
        [Required]
        [StringLength(5)]
        public required bool TransmitterFlag { get; set; }

        public PhoneNumber? PhoneNumber { get; set; }

        /// <summary>
        /// Australian Business Number
        /// </summary>
        [StringLength(11)]
        [RegularExpression(RegexPattern.NUMBERS)]
        public string? ABN { get; set; }

        public PhoneNumber? FaxNumber { get; set; }

        public List<Address>? Addresses { get; set; }

        public List<Contact>? Contacts { get; set; }
    }
}
