using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Aggregates.PaymentAdviceDetailAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.PaymentAdviceAggregate
{
    public class PaymentAdvice
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        public List<Organisation>? FinalreceiverList { get; set; }

        [Required]
        public required List<PaymentAdviceDetail> PaymentAdviceDetailList { get; set; }

        public List<Comment>? Comments { get; set; }
    }
}
