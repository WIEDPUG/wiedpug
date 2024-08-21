using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.RequestForStatusAggregate
{
    public class RequestForStatus
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }
        public required List<RequestForStatusFilter> RequestForStatusFilters { get; set; }
    }
}
