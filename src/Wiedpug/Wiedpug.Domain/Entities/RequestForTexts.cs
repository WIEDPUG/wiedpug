using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class RequestForTexts
    {

        [StringLength(4)]
        public SaleIdentity? SaleIdentity { get; set; }

        [StringLength(5)]
        public string? OrganisationRequested { get; set; }

        /// <summary>
        /// Date value in ISO 8601 standard. e.g. 2024-03-21
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [StringLength(10)]
        public string? SaleDateRequested { get; set; }

        /// <summary>
        /// Date and Time value in ISO 8601 standard UTC format. e.g. 2024-03-21T19:25:04Z
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [StringLength(20)]
        public string? StartDateTimeStatusRequest { get; set; }

        /// <summary>
        /// Date and Time with offset value in ISO 8601 standard UTC format. e.g. 2024-03-21T19:25:04Z
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [StringLength(20)]
        public string? EndDateTimeStatusRequest { get; set; }

        [StringLength(5)]
        public bool? UseNetworkDateTime { get; set; }

        [Required]
        [StringLength(1)]
        public required RequestTypeForData RequestType { get; set; }

        [StringLength(4)]
        public WoolTypeGroup? WoolTypeGroup { get; set; }

        /// <summary>
        /// Record types and record sub-types to be excluded. e.g. 20 - Lot Header, 22A - Group Header
        /// </summary>
        /// 
        [StringLength(80)]
        public List<String>? RecordTypesToBeExcluded { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? Season { get; set; }
    }
}
