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
        [StringLength(1)]
        public required CatalogueType CatalogueType { get; set; }

        /// <summary>
        /// Used to define document transfer type: unrestricted, restricted or exclusion
        /// Should only be required for document upload/create/update
        /// Should be excluded when returning document to members
        /// </summary>
        public TransferConfig? TransferConfig { get; set; }

        [Required]
        public required List<CatalogueWoolSaleHeader> WoolSaleHeaders { get; set; }        
    }
}
