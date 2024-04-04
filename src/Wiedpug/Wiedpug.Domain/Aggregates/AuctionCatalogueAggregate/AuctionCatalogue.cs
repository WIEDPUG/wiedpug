﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class AuctionCatalogue
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }
        
        [Required]
        public required WoolSaleHeaderLots WoolSaleHeaderLots { get; set; }

        public required CombinationFlag CombinationFlag { get; set; }

        public required YieldType YieldType { get; set; }
    }
}
