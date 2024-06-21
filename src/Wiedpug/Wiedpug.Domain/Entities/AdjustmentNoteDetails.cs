using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class AdjustmentNoteDetails
    {
        [Required]
        [StringLength(8)]
        public required Organisation Client { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_8_DIGITS)]
        public required int CreditNoteInvoiceNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        public required string DateOfCreditNote { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_6_2)]
        public required double CreditNoteAmount { get; set; }

        [Required]
        [StringLength(5)]
        public required bool IsGSTApplicable { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_6_2)]
        public required double GSTAmount { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int ReasonCode { get; set; }

        [Required]
        [StringLength(11)]
        public required CertificateIdentity CertificateIdentityOriginal { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        public required string DateOfOriginalInvoice { get; set; }

        [Required]
        [StringLength(11)]
        public required CertificateIdentity NewCertificateIdentity { get; set; }
    }
}
