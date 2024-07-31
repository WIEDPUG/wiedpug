using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class LotHeaderPricingDataOffer
    {
        [Required]
        [MinLength(3)]
        [MaxLength(6)]
        public required PriceCurrency? OfferPrice { get; set; } // FIELD NUMBER 5 - Offer Price (1) - Start: 6, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        /// <summary>
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string OfferDate { get; set; }
    }
}
