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
        [Range(-999999,999999)]
        public required int ClientCode { get; set; }

        /// <summary>
        /// The period ending date of the statement
        /// </summary>
        [Required]
        public required UtcDate StatementDate { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency AmountRemitted { get; set; }

        /// <summary>
        /// The date the payment was made
        /// </summary>
        [Required]
        public required UtcDate StatementPaymentDate { get; set; }

        [Required]
        [Range(-999999,999999)]
        public required int BankBsbNumber { get; set; }

        [Required]
        [Range(-999999999,999999999)]
        public required int BankAccountNumber { get; set; }
        
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? AmountWithheldThisStatement { get; set; }

        [MinLength(6)]
        [MaxLength(15)]
        public Currency? AmountWithheldPreviousStatements { get; set; }
    }

}