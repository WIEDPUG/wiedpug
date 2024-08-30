using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class OrganisationInformationDetail
    {
        public string? Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation Organisation { get; set; }

        /// <summary>
        /// he name of a person or organisation.
        /// Contact – Name of a person in the organisation that can be contacted for further information.
        /// Organisation – the name of the organisation.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public required string NameOfOrganisation { get; set; }

        /// <summary>
        /// The day the item was last amended.
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>        
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string DateLastUpdated { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required IndustryGroupId IndustryGroupId { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the organisation transmits or receives data electronically.
        /// 
        /// true: The organisation transmits or receives data electronically. 
        /// 
        /// false: The organisation neither transmits nor receives data electronically.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(5)]
        public required bool IsTransmitter { get; set; }

        public PhoneNumber? PhoneNumber { get; set; }

        /// <summary>
        /// Australian Business Number
        /// </summary>
        [MinLength(1)]
        [MaxLength(11)]
        [RegularExpression(RegexPattern.NUMBERS)]
        public string? Abn { get; set; }

        /// <summary>
        /// The number to be used for sending facsimile messages to the organisation
        /// </summary>
        public PhoneNumber? FaxNumber { get; set; }

        public List<Address>? Addresses { get; set; }

        public List<Contact>? Contacts { get; set; }
    }
}
