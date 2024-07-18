using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class StatementDetail
    {
        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public required string ClientsReference { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required string AccountReference { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        [MinLength(1)]
        [MaxLength(9)]
        public required double Amount { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public AmountType? AmountType { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? ItemDate { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_6_2)]
        [MinLength(1)]
        [MaxLength(6)]
        public double? GstAmount { get; set; }

        /// <summary>
        /// Boolean value of wethear GST amount is applicable to invoice
        /// True for applicable, False for not applicable
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required bool GstTaxInvoiceApplicable { get; set; }

        /// <summary>
        /// Boolean value of wethear Company ABN apply to invoice
        /// True for applicable, False for not applicable
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required bool CompanyABNApplicable { get; set; }
    }

}