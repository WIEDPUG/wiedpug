using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class AdjustmentNoteDetail
    {
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation Client { get; set; }

        /// <summary>
        /// Invoice number of the credit
        /// </summary>
        [Required]
        [Range(-99999999,99999999)]
        public required int CreditNoteInvoiceNumber { get; set; }

        /// <summary>
        /// Date the Credit note was issued
        ///
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
        public required LiteralDate DateOfCreditNote { get; set; }

        /// <summary>
        /// Amount to be credited
        /// </summary>
        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency CreditNoteAmount { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the GST is aplicable.
        /// 
        /// true: applicable.
        ///
        /// false: not applicable.
        /// </summary>
        [Required]

        public required bool IsGstApplicable { get; set; }

        /// <summary>
        /// Goods & Services Tax Amount
        /// </summary>
        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency GSTAmount { get; set; }

        /// <summary>
        /// Reason credit note was raised
        /// </summary>
        [Required]
        [Range(-99,99)]
        public required int ReasonCode { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentityOriginal { get; set; }

        /// <summary>
        /// Date of the original invoice
        ///
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
        [Required]
        public required LiteralDate DateOfOriginalInvoice { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentityNew { get; set; }
    }
}
