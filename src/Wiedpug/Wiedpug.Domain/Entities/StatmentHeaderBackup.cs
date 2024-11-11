using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class StatementHeaderBackup
    {
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation Client { get; set; }

        [Required]
        [Range(-999999,999999)]
        public required int ClientCode { get; set; }

        /// <summary>
        /// The period ending date of the statement
        /// </summary>
        [Required]
        public required LiteralDate StatementDate { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitOrCreditType DebitOrCreditTypeCurrent { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency OpeningBalanceCurrent { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitOrCreditType DebitOrCreditType30 { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency OpeningBalance30 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitOrCreditType DebitOrCreditType60 { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency OpeningBalance60 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitOrCreditType DebitOrCreditType90 { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency OpeningBalance90 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitOrCreditType DebitOrCreditType90Plus { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency OpeningBalance90Plus { get; set; }
    }

}