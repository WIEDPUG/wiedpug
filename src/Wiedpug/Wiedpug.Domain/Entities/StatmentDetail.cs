using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class StatementDetail
    {
        [Required]
        public required string ClientsReference { get; set; }

        [Required]
        public required Organisation AccountReference { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal Amount { get; set; }

        public AmountType? AmountType { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public string? ItemDate { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public decimal? GstAmount { get; set; }

        /// <summary>
        /// Boolean value of wethear GST amount is applicable to invoice
        /// True for applicable, False for not applicable
        /// </summary>
        [Required]
        public required bool GstTaxInvoiceApplicable { get; set; }

        /// <summary>
        /// Boolean value of wethear Company ABN apply to invoice
        /// True for applicable, False for not applicable
        /// </summary>
        [Required]
        public required bool CompanyABNApplicable { get; set; }
    }

}