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
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required int ClientCode { get; set; }

        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string StatementDate { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitOrCreditFlag DebitOrCreditFlagCurrent { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency OpeningBalanceCurrent { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitOrCreditFlag DebitOrCreditFlag30 { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency OpeningBalance30 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitOrCreditFlag DebitOrCreditFlag60 { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency OpeningBalance60 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitOrCreditFlag DebitOrCreditFlag90 { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency OpeningBalance90 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitOrCreditFlag DebitOrCreditFlag90Plus { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency OpeningBalance90Plus { get; set; }
    }

}