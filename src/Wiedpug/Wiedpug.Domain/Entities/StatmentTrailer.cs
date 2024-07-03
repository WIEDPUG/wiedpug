using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class StatementTrailer
    {
        [Required]
        [StringLength(1)]
        public required DebitCreditFlag DebitOrCreditFlag1 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        [StringLength(9)]
        public required double ClosingBalanceCurrent { get; set; }

        [Required]
        [StringLength(1)]
        public required DebitCreditFlag DebitOrCreditFlag2 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        [StringLength(9)]
        public required double ClosingBalance30 { get; set; }

        [Required]
        [StringLength(1)]
        public required DebitCreditFlag DebitOrCreditFlag3 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        [StringLength(9)]
        public required double ClosingBalance60 { get; set; }

        [Required]
        [StringLength(1)]
        public required DebitCreditFlag DebitOrCreditFlag4 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        [StringLength(9)]
        public required double ClosingBalance90 { get; set; }

        [Required]
        [StringLength(1)]
        public required DebitCreditFlag DebitOrCreditFlag5 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        [StringLength(9)]
        public required double ClosingBalance90Plus { get; set; }
    }

}