using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class StatementHeader
    {
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation Client { get; set; }

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
        public required List<Balance> OpeningBalances { get; set; }

    }

}