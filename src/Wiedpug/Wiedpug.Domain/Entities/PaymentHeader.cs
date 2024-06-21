using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class PaymentHeader
    {
        [Required]
        public required Organisation ClientCode { get; set; }

        [Required]
        public required string StatementDate { get; set; }

        [Required]
        public double AmountEmitted { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [StringLength(10)]
        public required string StatementPaymentDate { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required string BankBSBNumber { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_9_DIGITS)]
        public required string BankAccountNumber { get; set; }
        
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        public required double AmountWithheldThisStatement { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        public required double AmountWithheldPreviousStatements { get; set; }
    }

}