using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.PaymentAdviceDetailAggregate
{
    public class PaymentAdviceDetail
    {
        [Required]
        public required PaymentAdviceWoolSaleHeaderLots WoolSaleHeaderLots { get; set; }

        [Required]
        public required List<LotPaymentDetail> LotPaymentDetails { get; set; }

        public List<MiscellaneousCharge>? MiscellaneousCharges { get; set; }

        [Required]
        public required PaymentSummary PaymentSummary { get; set; }

    }
}
