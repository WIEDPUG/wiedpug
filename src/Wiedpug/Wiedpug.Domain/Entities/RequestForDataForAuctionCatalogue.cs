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
    public class RequestForDataForAuctionCatalogue
    {
        [Required]
        public required TransmissionTypeForAuctionCatalogue TransmissionTypeRequested { get; set; }

        public SaleIdentity? SaleIdentity { get; set; }

        public string? OrganisationRequested { get; set; }

        /// <summary>
        /// Date value in ISO 8601 standard. e.g. 2024-03-21
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public string? SaleDateRequested { get; set; }

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

        [Required]
        public required RequestTypeForData RequestType { get; set; }

        public WoolTypeGroup? WoolTypeGroup { get; set; }

        /// <summary>
        /// Record types and record sub-types to be excluded. e.g. 20 - Lot Header, 22A - Group Header.
        /// 
        /// </summary>
        public List<RecordTypesToBeExcludedForAuctionCatalogue>? RecordTypesToBeExcluded { get; set; }

        public int? Season { get; set; }
    }
}
