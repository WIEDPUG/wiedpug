using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class StatementHeader
    {
        [Required]
        public required Organisation Client { get; set; }

        [Required]
        public required int ClientCode { get; set; }

        [Required]
        public required string StatementDate { get; set; }

        [Required]
        public required DebitCreditFlag DebitOrCreditFlag1 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        public required double OpeningBalanceCurrent { get; set; }

        [Required]
        public required DebitCreditFlag DebitOrCreditFlag2 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        public required double OpeningBalance30 { get; set; }

        [Required]
        public required DebitCreditFlag DebitOrCreditFlag3 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        public required double OpeningBalance60 { get; set; }

        [Required]
        public required DebitCreditFlag DebitOrCreditFlag4 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        public required double OpeningBalance90 { get; set; }

        [Required]
        public required DebitCreditFlag DebitOrCreditFlag5 { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        public required double OpeningBalance90Plus { get; set; }
    }

}