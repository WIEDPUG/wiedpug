using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class GetOrganizationDetailsRequest
    {
        [Required]
        public required CountryCode CountryOfOrigin { get; set; }

        [Required]
        public required string DocumentOriginator { get; set; }

        [Required]
        public required string CurrentTransmitter { get; set; }

        [Required]
        public required string CurrentReceiver { get; set; }

        [Required]
        public required string FinalReceiver { get; set; }

        public SoftwareIdentifier? SoftwareIdentifier { get; set; }

        [Required]
        public required string Abn { get; set; }

        /// <summary>
        /// Date and Time with offset value in ISO 8601 standard. e.g. 2024-03-21T19:25:04+00:00
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_WITH_OFFSET_ISO8601)]
        public string? StartDateTimeStatusRequest { get; set; }

        /// <summary>
        /// Date and Time with offset value in ISO 8601 standard. e.g. 2024-03-21T19:25:04+00:00
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_WITH_OFFSET_ISO8601)]
        public string? EndDateTimeStatusRequest { get; set; }

        public bool? UserNetworkDateTime { get; set; }
    }
}
