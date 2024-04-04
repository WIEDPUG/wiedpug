using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class AuctionCatalogueWoolSaleHeaderLotHistogram
    {
        [Required]
        public required FibreDiameterHistogramHeader FibreDiameterHistogramHeader { get; set; }
        
        [Required]
        [Range(0, 9)]
        public required List<FibreDiameterHistogramDetail> FibreDiameterHistogramDetails { get; set; }
    }
}
