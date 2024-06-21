using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.PaymentConfirmationAggregate
{
    public class PaymentConfirmation
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        [Required]
        public required List<Confirmation> Confirmations { get; set; }
    }
}
