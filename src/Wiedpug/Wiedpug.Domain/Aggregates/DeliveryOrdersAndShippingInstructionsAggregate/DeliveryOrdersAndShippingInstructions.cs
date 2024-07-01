using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.DeliveryOrdersAndShippingInstructionsAggregate
{
    public class DeliveryOrdersAndShippingInstructions
    {
        [Required]
        public required List<DeliveryOrdersAndShippingInstruction> DeliveryOrdersAndShippingInstructionCollection { get; set; }
    }
}
