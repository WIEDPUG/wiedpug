using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.DeliveryOrdersAndShippingInstructionsAggregate
{
    public class DeliveryOrder
    {
        [Required]
        public required DeliveryOrderDetail DeliveryOrderDetail { get; set; }

        public List<Comment>? Comments { get; set; }

        public required List<DeliveryOrderLot> DeliveryOrderLots { get; set; }


    }
}
