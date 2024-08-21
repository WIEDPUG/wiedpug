using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class CatalogueWoolSaleHeaderLot
    {
        public LotHeader? LotHeader { get; set; }

        public List<LotHeaderPricing>? LotHeaderPricings { get; set; }

        public EncryptedLotHeaderAwexData? EncryptedLotHeaderAwexData { get; set; }

        [Required]
        public required List<LotHeaderVendorDeclaration> LotHeaderVendorDeclarations { get; set; }

        public TestDetail? TestDetail { get; set; }

        public ColourTestDetail? ColourTestDetail { get; set; }

        public LengthAndStrengthTestDetail? LengthAndStrengthTestDetail { get; set; }

        public List<FibreDiameterHistogram>? FibreDiameterHistograms { get; set; }
        
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
