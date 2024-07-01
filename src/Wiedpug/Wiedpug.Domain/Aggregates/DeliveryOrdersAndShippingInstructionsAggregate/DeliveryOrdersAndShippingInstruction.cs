using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.DeliveryOrdersAndShippingInstructionsAggregate
{
    public class DeliveryOrdersAndShippingInstruction
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        [StringLength(8)]
        public List<Organisation>? FinalReceiverList { get; set; }

        [Required]
        public required List<Consignment> Consignments { get; set; }
    }
}
