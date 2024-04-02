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
    public class WoolSaleHeaderNonAuction
    {
        /// <summary>
        /// Date and Time with offset value in ISO 8601 standard. e.g. 2024-03-21T19:25:04+00:00
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_WITH_OFFSET_ISO8601)]
        public string? CatalogueAvailabilityDateTime { get; set; } // FIELD NUMBER 4 - Catalogue Availability Time - Start: 10, Size: 4, Data Type: Time, Justification: L, Requirement Designator: O

        /// <summary>
        /// Date and Time with offset value in ISO 8601 standard. e.g. 2024-03-21T19:25:04+00:00
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_WITH_OFFSET_ISO8601)]
        public string? SaleStartDateTime { get; set; } // FIELD NUMBER 5 - Sale Start Date - Start: 14, Size: 6, Data Type: Date, Justification: L, Requirement Designator: O

        /// <summary>
        /// Date and Time with offset value in ISO 8601 standard. e.g. 2024-03-21T19:25:04+00:00
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_WITH_OFFSET_ISO8601)]
        public string? SaleEndDateTime { get; set; } // FIELD NUMBER 7 - Sale End Date - Start: 24, Size: 6, Data Type: Date, Justification: L, Requirement Designator: O

        public SaleType? SaleType { get; set; } // FIELD NUMBER 9 - Sale Type - Start: 34, Size: 2, Data Type: ID, Justification: L, Requirement Designator: O

        public bool? ElectronicSaleFlag { get; set; } // FIELD NUMBER 10 - Electronic Sale Flag - Start: 36, Size: 1, Data Type: ID, Justification: L, Requirement Designator: O

        /// <summary>
        /// `true` = Available to Buyers, `false` = Not available to buyers.
        /// </summary>
        public bool? ReservePriceDisplayFlag { get; set; } // FIELD NUMBER 11 - Reserve Price Display Flag - Start: 37, Size: 1, Data Type: ID, Justification: F, Requirement Designator: O

        /// <summary>
        /// Date and Time with offset value in ISO 8601 standard. e.g. 2024-03-21T19:25:04+00:00
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_WITH_OFFSET_ISO8601)]
        public string? TenderSaleReplyDateTime { get; set; } // FIELD NUMBER 12 - Tender Sale Reply Date - Start: 38, Size: 6, Data Type: Date, Justification: F, Requirement Designator: O
    }

}
