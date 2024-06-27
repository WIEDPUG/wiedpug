using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.StatementsAggregate
{
    public class Statement
    {
        [Required]
        public required StatementHeader StatementHeader { get; set; }

        [Required]
        public required List<StatementDetail> StatementDetails { get; set; }

        [Required]
        public required StatementTrailer StatementTrailer { get; set; }
    }
}
