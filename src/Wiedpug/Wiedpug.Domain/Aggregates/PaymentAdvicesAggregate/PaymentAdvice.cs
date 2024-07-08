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

        /// <summary>
        /// Used to define document transfer type: unrestricted, restricted or exclusion
        /// Should only be required for document upload/create/update
        /// Should be excluded when returning document to members
        /// </summary>
        public TransferConfig? TransferConfig { get; set; }

        [Required]
        public required List<PaymentAdviceDetail> PaymentAdviceDetailList { get; set; }

        public List<Comment>? Comments { get; set; }
    }
}
