using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class CatalogueWoolSaleHeaderLot
    {
        public LotHeader? LotHeader { get; set; }

        public List<LotHeaderPricingData>? LotHeaderPricings { get; set; }

        public EncryptedLotHeaderAwexData? EncryptedLotHeaderAwexData { get; set; }

        [Required]
        public required List<LotHeaderVendorDeclaration> LotHeaderVendorDeclarations { get; set; }

        public TestDetails? TestDetails { get; set; }

        public ColourTestDetails? ColourTestDetails { get; set; }

        public LengthAndStrengthTestDetails? LengthAndStrengthTestDetails { get; set; }

        public CombinationDetails? CombinationDetails { get; set; }

        public List<FibreDiameterHistogram>? Histograms { get; set; }
        
        /// <summary>
        /// This field is completely optional when sending Auction Catalogue Updates
        /// </summary>
        public CatalogueLotDescription? CatalogueLotDescription { get; set; }
        /// <summary>
        /// This field is completely optional when sending Auction Catalogue Updates
        /// </summary>
        public List<BaleIdentification>? BaleIdentifications { get; set; }
        /// <summary>
        /// This field is completely optional when sending Auction Catalogue Updates
        /// </summary>
        public List<InterlotComponentBale>? InterlotComponentBales { get; set; }

    }
}
