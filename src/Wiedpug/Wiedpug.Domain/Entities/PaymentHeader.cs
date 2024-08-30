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
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required int ClientCode { get; set; }

        /// <summary>
        /// The period ending date of the statement
        ///
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string StatementDate { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency AmountRemitted { get; set; }

        /// <summary>
        /// The date the payment was made
        ///
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
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
        
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? AmountWithheldThisStatement { get; set; }

        [MinLength(6)]
        [MaxLength(15)]
        public Currency? AmountWithheldPreviousStatements { get; set; }
    }

}