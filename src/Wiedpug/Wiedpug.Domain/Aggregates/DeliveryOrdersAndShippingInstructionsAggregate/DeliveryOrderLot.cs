using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.DeliveryOrdersAndShippingInstructionsAggregate
{
    public class DeliveryOrderLot
    {
        [Required]
        public required DeliveryOrderLotHeader DeliveryOrderLotHeader { get; set; }

        public required List<CountermarkHeadmark> CountermarkHeadmarks { get; set; }   

        public required List<Bale> Bales { get; set; }


    }
}
