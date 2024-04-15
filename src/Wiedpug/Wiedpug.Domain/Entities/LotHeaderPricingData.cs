﻿using System;
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
    public class LotHeaderPricingData
    {
        public PriceBasis? PriceBasis { get; set; } // FIELD NUMBER 3 - Price Basis - Start: 4, Size: 1, Data Type: ID, Justification: F, Requirement Designator: O

        public string? YieldBasis { get; set; } // FIELD NUMBER 4 - Yield Basis - Start: 5, Size: 1, Data Type: ID, Justification: F, Requirement Designator: O

        [MaxLength(6)]
        public List<LotHeaderPricingDataOffer>? Offers { get; set; }
    }
}
