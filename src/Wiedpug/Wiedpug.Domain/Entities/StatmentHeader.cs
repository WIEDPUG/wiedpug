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
        [Range(-999999,999999)]
        public required int ClientCode { get; set; }

        /// <summary>
        /// The period ending date of the statement
        /// </summary>
        [Required]
        public required UtcDate StatementDate { get; set; }

        [Required]
        public required List<Balance> OpeningBalances { get; set; }

    }

}