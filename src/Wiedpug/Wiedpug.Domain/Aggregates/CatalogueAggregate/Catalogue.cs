using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Attributes;
using System.ComponentModel;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class Catalogue
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        /// <summary>
        /// Used to define the type of catalogue
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required CatalogueType CatalogueType { get; set; }

        public TransferConfig? TransferConfig { get; set; }


        [Required]
        public required List<WoolSaleHeader> WoolSaleHeaders { get; set; }        
    }
}
