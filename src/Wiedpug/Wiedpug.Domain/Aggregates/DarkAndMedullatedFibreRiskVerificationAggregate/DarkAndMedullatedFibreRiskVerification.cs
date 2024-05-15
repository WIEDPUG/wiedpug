using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.LotInvoicesAggregate
{
    public class DarkAndMedullatedFibreRiskVerification

    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        public List<DarkAndMedullatedFibreRiskDetails>? DarkAndMedullatedFibreRiskDetailsCollection { get; set; }

    }
}
