using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class StatementTrailer
    {
        [Required]
        public required DebitCreditFlag DebitOrCreditFlag1 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal ClosingBalanceCurrent { get; set; }

        [Required]
        public required DebitCreditFlag DebitOrCreditFlag2 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal ClosingBalance30 { get; set; }

        [Required]
        public required DebitCreditFlag DebitOrCreditFlag3 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal ClosingBalance60 { get; set; }

        [Required]
        public required DebitCreditFlag DebitOrCreditFlag4 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal ClosingBalance90 { get; set; }

        [Required]
        public required DebitCreditFlag DebitOrCreditFlag5 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal ClosingBalance90Plus { get; set; }
    }

}