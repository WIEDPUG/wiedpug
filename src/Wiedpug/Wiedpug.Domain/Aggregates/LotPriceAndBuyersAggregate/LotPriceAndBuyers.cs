using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Aggregates.LotPriceAndBuyerAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.LotPriceAndBuyersAggregate
{
    public class LotPriceAndBuyers
    {
        [Required]
        public required List<LotPriceAndBuyer> LotPriceAndBuyerCollection { get; set; }
    }
}
