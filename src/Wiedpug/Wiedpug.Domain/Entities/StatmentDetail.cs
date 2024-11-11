using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class StatementDetail
    {
        /// <summary>
        /// Client’s Reference as per printed statement under heading “CLIENT REFERENCE”
        ///
        /// Examples:
        ///
        /// • The first 30 characters of sale/lot-number/brand/description for Test Certificates
        /// 
        /// • Type of Service, e.g. PSP, PRTPS, EDI, etc.
        ///
        /// • Old and new certificate number for auto credits EFT – Electronic Funds Transfer
        /// </summary>        
        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public required string ClientsReference { get; set; }

        /// <summary>
        /// Account Reference as per printed statement under heading “AWTA LTD REFERENCE”
        ///
        /// Examples:
        ///
        /// • Certificate Identity
        ///
        /// • Credit Note number
        ///
        /// • Debit Note number
        ///
        /// • Cheque number
        /// </summary>
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
        /// The date the cost of the item was incurred
        /// </summary>
        public LiteralDate?  ItemDate { get; set; }

        /// <summary>
        /// Goods & Services Tax Amount
        /// </summary>
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

        public required bool IsGstApplicable { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the Company ABN is applicable to invoice. 
        /// 
        /// true: applicable.
        /// 
        /// false: not applicable.
        /// </summary>
        [Required]

        public required bool IsCompanyAbnApplicable { get; set; }
    }

}