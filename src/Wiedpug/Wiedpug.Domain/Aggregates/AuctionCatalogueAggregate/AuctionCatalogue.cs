using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class AuctionCatalogue
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }
        
        [Required]
        public required WoolSaleHeaderLots WoolSaleHeaderLots { get; set; }
    }
}
