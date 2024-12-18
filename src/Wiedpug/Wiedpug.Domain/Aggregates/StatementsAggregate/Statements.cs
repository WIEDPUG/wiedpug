using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.StatementsAggregate
{
    public class Statements
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        /// <summary>
        /// Used to define document transfer type: unrestricted, restricted or exclusion.
        /// </summary>
        [Required]
        public required TransferConfig TransferConfig { get; set; }

        [Required]
        public required StatementHeader StatementHeader { get; set; }

        public List<StatementDetail>? StatementDetails { get; set; }

        [Required]
        public required StatementTrailer StatementTrailer { get; set; }
    }
}
