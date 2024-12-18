using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.PaymentConfirmationAggregate
{
    public class PaymentConfirmation
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        /// <summary>
        /// Used to define document transfer type: unrestricted, restricted or exclusion.
        /// </summary>
        [Required]
        public required TransferConfig TransferConfig { get; set; }

        [Required]
        public required List<Confirmation> Confirmations { get; set; }
    }
}
