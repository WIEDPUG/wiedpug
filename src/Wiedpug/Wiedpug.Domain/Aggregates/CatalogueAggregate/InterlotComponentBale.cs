using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate
{
    public class InterlotComponentBale
    {
        [Required]
        public required InterlotComponentBaleHeader InterlotComponentBaleHeader { get; set; }
        
        public List<BaleIdentification>? BaleIdentifications { get; set; }

    }
}
