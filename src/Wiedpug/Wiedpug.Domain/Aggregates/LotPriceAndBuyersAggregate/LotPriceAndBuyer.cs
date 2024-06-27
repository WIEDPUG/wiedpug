using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Aggregates.LotPriceAndBuyersAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.LotPriceAndBuyerAggregate
{
    public class LotPriceAndBuyer
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        [Required]
        public required List<Lot> Lots { get; set; }
    }
}
