using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.DeliveryOrdersAndShippingInstructionsAggregate
{
    public class Consignment
    {
        [Required]
        public required ConsignmentHeader ConsignmentHeader { get; set; }

        public required List<CountermarkHeadmark> CountermarkHeadmarks { get; set; }   

        public required List<DeliveryOrder> DeliveryOrders { get; set; }


    }
}
