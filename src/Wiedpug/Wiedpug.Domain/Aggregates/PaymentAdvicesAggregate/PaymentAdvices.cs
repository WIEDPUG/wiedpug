using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Aggregates.PaymentAdviceDetailAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.PaymentAdviceAggregate
{
    public class PaymentAdvices
    {
        [Required]
        public required List<PaymentAdvice> PaymentAdviceCollection { get; set; }

    }
}
