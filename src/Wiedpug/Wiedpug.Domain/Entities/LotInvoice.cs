using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class LotInvoice
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        public string? FinalReceiverList { get; set;}

        [Required]
        public required List<LotInvoiceContent> LotInvoiceContents { get; set; }
    }
}
