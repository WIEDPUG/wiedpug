using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class AuctionCatalogueWoolSaleHeaderLot
    {
        public LotHeader? LotHeader { get; set; }
        public LotHeaderExtension? LotHeaderExtension { get; set; }

        [MaxLength(2)]
        public List<LotHeaderPricingData>? LotHeaderPricings { get; set; }
        public LotHeaderAwexData? LotHeaderAwexData { get; set; }

        [Required]
        public required List<LotHeaderVendorDeclaration> LotHeaderVendorDeclarations { get; set; }

        //51 record types....

        public List<AuctionCatalogueWoolSaleHeaderLotHistogram>? Histograms { get; set; }
    }
}
