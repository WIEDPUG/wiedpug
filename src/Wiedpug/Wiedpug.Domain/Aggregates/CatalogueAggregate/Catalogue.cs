using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class Catalogue
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        /// <summary>
        /// Used to define the type of catalogue: 1 - Action Catalogue, 2 - Private Catalogue
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required CatalogueType CatalogueType { get; set; }

        public TransferConfig? TransferConfig { get; set; }

        [Required]
        public required List<CatalogueWoolSaleHeader> WoolSaleHeaders { get; set; }        
    }
}
