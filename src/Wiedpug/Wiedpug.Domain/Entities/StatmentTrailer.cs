using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class StatementTrailer
    {
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitCreditFlag DebitOrCreditFlagCurrent { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency ClosingBalanceCurrent { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitCreditFlag DebitOrCreditFlag30 { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency ClosingBalance30 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitCreditFlag DebitOrCreditFlag60 { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency ClosingBalance60 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitCreditFlag DebitOrCreditFlag90 { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency ClosingBalance90 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitCreditFlag DebitOrCreditFlag90Plus { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency ClosingBalance90Plus { get; set; }
    }

}