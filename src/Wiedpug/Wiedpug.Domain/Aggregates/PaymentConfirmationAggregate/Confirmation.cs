using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.PaymentConfirmationAggregate
{
    public class Confirmation
    {
        [Required]
        public required PaymentHeader PaymentHeader { get; set; }

        [Required]
        public required List<PaymentDetail> PaymentDetails { get; set; }
    }
}
