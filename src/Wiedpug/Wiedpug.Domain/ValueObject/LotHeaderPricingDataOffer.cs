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
        public required Currency? OfferPrice { get; set; } // FIELD NUMBER 5 - Offer Price (1) - Start: 6, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string OfferDate { get; set; }
    }
}
