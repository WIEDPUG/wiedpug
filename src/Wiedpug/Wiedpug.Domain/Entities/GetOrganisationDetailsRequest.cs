using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class GetOrganisationDetailsRequest
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get;  set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required CountryCode CountryOfOrigin { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation DocumentOriginator { get; set; }

        public SoftwareIdentifier? SoftwareIdentifier { get; set; }

        /// <summary>
        /// Australian Business Number
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required string Abn { get; set; }

        /// <summary>
        /// Date and Time in UTC format in ISO 8601 standard. Format: YYYY-MM-DDTHH:mm:ssZ e.g. 2024-03-21T19:25:04Z
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(20)]
        public string? StartDateTimeStatusRequest { get; set; }

        /// <summary>
        /// Date and Time in UTC format in ISO 8601 standard. Format: YYYY-MM-DDTHH:mm:ssZ. e.g. 2024-03-21T19:25:04Z
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(20)]
        public string? EndDateTimeStatusRequest { get; set; }

        /// <summary>
        /// A boolean value to indicate whether to use network datetime.
        ///
        /// true: use network datetime.
        ///
        /// false: not use.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsUsingNetworkDateTime { get; set; }
    }
}
