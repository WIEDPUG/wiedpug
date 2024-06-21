using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.PaymentAdvicesAggregate
{
    public class PaymentAdvices
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        [Required]
        public required List<OrganisationDetail> OrganisationDetailCollection { get; set; }
    }
}
