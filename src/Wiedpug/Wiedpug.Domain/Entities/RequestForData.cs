using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class RequestForData
    {
        [Required]
        [StringLength(2)]
        public required TransmissionType TransmissionTypeRequested { get; set; }

        [StringLength(4)]
        public SaleIdentity? SaleIdentity { get; set; }

        [StringLength(5)]
        public string? OrganisationRequested { get; set; }

        /// <summary>
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [StringLength(10)]
        public string? SaleDateRequested { get; set; }

        /// <summary>
        /// Date and Time value in ISO 8601 standard UTC datetime format. e.g. 2024-03-21T19:25:04.000Z
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [StringLength(24)]
        public string? StartDateTimeStatusRequest { get; set; }

        /// <summary>
        /// Date and Time value in ISO 8601 standard UTC datetime format. e.g. 2024-03-21T19:25:04.000Z
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [StringLength(24)]
        public string? EndDateTimeStatusRequest { get; set; }

        [StringLength(4)]
        public bool? UserNetworkDateTime { get; set; }

        [Required]
        [StringLength(1)]
        public required RequestType RequestType { get; set; }

        [StringLength(4)]
        public WoolTypeGroup? WoolTypeGroup { get; set; }

        /// <summary>
        /// Record types and record sub-types to be excluded. e.g. 20 - Lot Header, 22A - Group Header
        /// </summary>
        public List<string>? RecordTypesToBeExcluded { get; set; }

        /// <summary>
        /// Two digits number
        /// </summary>
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? Season { get; set; }

    }
}
