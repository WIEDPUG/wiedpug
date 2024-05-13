using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class AuctionCatalogueWoolSaleHeader
    {
        [Required]
        public required AuctionCatalogueWoolSaleHeaderLots WoolSaleHeaderLots { get; set; }
        
        [Required]
        public required WoolSaleHeaderExtension WoolSaleHeaderExtension { get; set; }
        
        public WoolSaleHeaderNonAuction? WoolSaleHeaderNonAuction { get; set; }

        [Required]
        public required List<AuctionCatalogueWoolSaleHeaderLot> Lots { get; set; }        
    }
}
