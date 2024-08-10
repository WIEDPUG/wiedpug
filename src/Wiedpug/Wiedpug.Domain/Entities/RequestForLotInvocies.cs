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
        /// <summary>
        /// A group field of SellingCentre/Type and Sale Number
        ///
        /// From: The current value that the Sale Identity is to be changed from.
        ///
        /// To: The new value that the Sale Identity is to be changed to.
        ///
        /// SellingCentre/Type can be one of the following code:
        ///
        /// SellingCentre/Type (New Zealand):
        ///
        /// C: Christchurch; N: Napier.
        ///
        /// SellingCentre/Type (Australia):
        ///
        /// A: Adelaide; AU: Australia; B: Brisbane; F: Fremantle; G: Geelong; L: Launceston; M: Melbourne; N: Newcastle; R: Goulburn; S: Sydney; PS: Private Sales; T: Auctions Plus Sales.
        /// </summary>
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
        /// Date and Time value in ISO 8601 standard UTC format. e.g. 2024-03-21T19:25:04Z
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(20)]
        public string? EndDateTimeStatusRequest { get; set; }

        /// <summary>
        /// A boolean value to indicate whether to use network datetime.
        /// true: use network datetime.
        /// false: not use.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsUsingNetworkDateTime { get; set; }

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
