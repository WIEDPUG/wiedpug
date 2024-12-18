using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.LotInvoicesAggregate
{
    public class DarkAndMedullatedFibreRiskVerification

    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        /// <summary>
        /// Used to define document transfer type: unrestricted, restricted or exclusion.
        /// </summary>
        [Required]
        public required TransferConfig TransferConfig { get; set; }

        public List<DarkAndMedullatedFibreRiskDetail>? DarkAndMedullatedFibreRiskDetails { get; set; }

    }
}
