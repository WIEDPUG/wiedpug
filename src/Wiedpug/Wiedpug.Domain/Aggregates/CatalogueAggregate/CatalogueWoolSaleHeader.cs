using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class CatalogueWoolSaleHeader
    {
        [Required]
        public required WoolSaleHeaderLots WoolSaleHeaderLots { get; set; }
       

        [Required]
        public required List<CatalogueWoolSaleHeaderLot> Lots { get; set; }        
    }
}
