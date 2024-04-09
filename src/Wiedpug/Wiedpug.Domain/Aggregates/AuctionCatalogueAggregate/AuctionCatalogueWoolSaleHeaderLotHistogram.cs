using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class AuctionCatalogueWoolSaleHeaderLotHistogram
    {
        [Required]
        public required FibreDiameterHistogramHeader FibreDiameterHistogramHeader { get; set; }
                        
        public List<FibreDiameterHistogramDetail>? FibreDiameterHistogramDetails { get; set; }
    }
}
