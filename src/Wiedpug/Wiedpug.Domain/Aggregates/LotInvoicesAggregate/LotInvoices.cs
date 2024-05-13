using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.LotInvoicesAggregate
{
    public class LotInvoices

    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        public List<LotInvoice>? LotInvoiceCollection { get; set; }

    }
}
