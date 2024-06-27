using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.LotPriceAndBuyersAggregate
{
    public class Lot
    {
        [Required]
        public required LotPriceAndBuyerWoolSaleHeaderLots WoolSaleHeaderLots { get; set; }

        public List<LotPriceAndBuyerDetail>? LotPriceAndBuyerDetails { get; set; }

        public RecordSaleStatus? RecordSaleStatus { get; set; }
    }
}
