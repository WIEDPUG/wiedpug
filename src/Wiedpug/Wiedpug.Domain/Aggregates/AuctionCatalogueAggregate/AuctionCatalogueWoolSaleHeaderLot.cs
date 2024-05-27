using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class AuctionCatalogueWoolSaleHeaderLot
    {
        public LotHeader? LotHeader { get; set; }
        public LotHeaderExtension? LotHeaderExtension { get; set; }

        public List<LotHeaderPricingData>? LotHeaderPricings { get; set; }
        public LotHeaderAwexData? LotHeaderAwexData { get; set; }

        [Required]
        public required List<LotHeaderVendorDeclaration> LotHeaderVendorDeclarations { get; set; }

        public ColourDetails? ColourDetails { get; set; }
        public PremiumTestDetails? PremiumTestDetails { get; set; }
        public SubjectiveInterlotDetails? SubjectiveInterlotDetails { get; set; }
        public CombinationDetails? CombinationDetails { get; set; }
        public LengthAndStrengthCombDetails? LengthAndStrengthCombDetails { get; set; }
        public LengthAndStrengthDetails? LengthAndStrengthDetails { get; set; }
        public OMLDetails? OmlDetails { get; set; }
        public CoreTestDetails? CoreTestDetails { get; set; }
        public ColourCombinationDetails? ColourCombinationDetails { get; set; }
        public OMIDetails? OmiDetails { get; set; }
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
        public List<AuctionCatalogueWoolSaleHeaderLotInterlotComponentBale>? InterlotComponentBales { get; set; }

    }
}
