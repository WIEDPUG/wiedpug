using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.StatementsAggregate
{
    public class StatementInformationDetail
    {
        [Required]
        public required StatementHeader StatementHeader { get; set; }

        public List<StatementDetail>? StatementDetails { get; set; }

        [Required]
        public required StatementTrailer StatementTrailer { get; set; }
    }
}
