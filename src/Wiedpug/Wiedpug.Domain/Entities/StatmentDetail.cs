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
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency Amount { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public AmountType? AmountType { get; set; }

        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? ItemDate { get; set; }

        [MinLength(6)]
        [MaxLength(15)]
        public Currency? GstAmount { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the GST amount is applicable to invoice. 
        /// 
        /// true: applicable.
        /// 
        /// false: not applicable.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(5)]
        public required bool IsGstTaxInvoiceApplicable { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the Company ABN is applicable to invoice. 
        /// 
        /// true: applicable.
        /// 
        /// false: not applicable.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(5)]
        public required bool IsCompanyABNApplicable { get; set; }
    }

}