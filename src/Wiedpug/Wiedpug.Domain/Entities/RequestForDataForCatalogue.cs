using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class RequestForDataForCatalogue
    {
        /// <summary>
        /// Used to define the types of Catalogue
        /// Only required for request for Catalogue. Not applicable for other documents.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(23)]
        public CatalogueTransmissionType? CatalogueTransmissionType { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        public SaleIdentity? SaleIdentity { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public Organisation? OrganisationRequested { get; set; }

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

        /// <summary>
        /// A boolean value to indicate whethear to use network datetime.
        /// true: use network datetime.
        /// false: not use.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsUsingNetworkDateTime { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        public WoolTypeGroup? WoolTypeGroup { get; set; }

        /// <summary>
        /// Cataglouge classes and sub-classes to be excluded in the request. e.g. 20 - Lot Header, 22A - Group Header.
        /// Only required for request for Catalogue. Not applicable for other documents.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(80)]
        public List<ExcludedClass>? ExcludedClasses { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? Season { get; set; }
    }
}
