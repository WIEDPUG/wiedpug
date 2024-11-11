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
        /// Australian Business Number, 11 digits
        /// </summary>
        [Required]
        [Range(10000000000,99999999999)]
        public required long Abn { get; set; }

        /// <summary>
        /// Date and Time in UTC format in ISO 8601 standard. Format: YYYY-MM-DDTHH:mm:ssZ e.g. 2024-03-21T19:25:04Z
        /// </summary>
        public UtcDateTime? StartDateTimeStatusRequest { get; set; }

        /// <summary>
        /// Date and Time in UTC format in ISO 8601 standard. Format: YYYY-MM-DDTHH:mm:ssZ. e.g. 2024-03-21T19:25:04Z
        /// </summary>
        public UtcDateTime? EndDateTimeStatusRequest { get; set; }

        /// <summary>
        /// A boolean value to indicate whether to use network datetime.
        ///
        /// true: use network datetime.
        ///
        /// false: not use.
        /// </summary>
        public bool? IsUsingNetworkDateTime { get; set; }
    }
}
