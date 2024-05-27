using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class AuctionCatalogue
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        /// <summary>
        /// Used to define document transfer type: broadcast or private-sent
        /// Should only be required for document upload/create/update
        /// Should be excluded when returning document to members
        /// </summary>
        public TransferConfig? TransferConfig { get; set; }

        [Required]
        public required List<AuctionCatalogueWoolSaleHeader> WoolSaleHeaders { get; set; }        
    }
}
