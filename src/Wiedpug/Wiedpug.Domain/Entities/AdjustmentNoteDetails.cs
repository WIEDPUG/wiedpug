using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class AdjustmentNoteDetails
    {
        [Required]
        public required Client Client { get; set; }

        [Required]
        public required int CreditNoteInvoiceNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string DateOfCreditNote { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal CreditNoteAmount { get; set; }

        [Required]
        public required Boolean IsGSTApplicable { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal GSTAmount { get; set; }

        [Required]
        public required string ReasonCode { get; set; }

        [Required]
        public required string CertificateIdentityOriginal { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string DateOfOriginalInvoice { get; set; }

        [Required]
        public required string NewCertificateIdentity { get; set; }
    }
}
