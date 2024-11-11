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

        [Required]
        public required LiteralDate OfferDate { get; set; }
    }
}
