using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class RequestForLotInvoices
    {
        [MinLength(1)]
        [MaxLength(4)]
        public SaleIdentity? SaleIdentity { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public string? OrganisationRequested { get; set; }

        /// <summary>
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? SaleDateRequested { get; set; }

        /// <summary>
        /// Date and Time value in ISO 8601 standard UTC datetime. e.g. 2024-03-21T19:25:04Z
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(20)]
        public string? StartDateTimeStatusRequest { get; set; }

        /// <summary>
        /// Date and Time with offset value in ISO 8601 standard. e.g. 2024-03-21T19:25:04+00:00
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(20)]
        public string? EndDateTimeStatusRequest { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public bool? UseNetworkDateTime { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required RequestTypeForData RequestType { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        public WoolTypeGroup? WoolTypeGroup { get; set; }

        /// <summary>
        /// Record types and record sub-types to be excluded. e.g. Lot Header, Group Header.
        /// 
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(80)]
        public List<String>? RecordTypesToBeExcluded { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? Season { get; set; }
    }
}
