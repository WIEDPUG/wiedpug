using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class LotInvoiceContent
    {
        [Required]
        public required WoolSaleHeaderLots WoolSaleHeaderLots  { get; set; }

        [Required]
        public required WoolSaleHeaderExtension WoolSaleHeaderExtension { get; set; }

        [Required]
        public required List<LotInvoiceDetail> LotInvoiceDetails { get; set; }
    }
}
