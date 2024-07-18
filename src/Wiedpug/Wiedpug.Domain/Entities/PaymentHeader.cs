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
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation ClientCode { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string StatementDate { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        [MinLength(1)]
        [MaxLength(9)]
        public double AmountEmitted { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string StatementPaymentDate { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        [MinLength(1)]
        [MaxLength(6)]
        public required string BankBSBNumber { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_9_DIGITS)]
        [MinLength(1)]
        [MaxLength(9)]
        public required string BankAccountNumber { get; set; }
        

        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        [MinLength(1)]
        [MaxLength(9)]
        public double? AmountWithheldThisStatement { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        [MinLength(1)]
        [MaxLength(9)]
        public double? AmountWithheldPreviousStatements { get; set; }
    }

}