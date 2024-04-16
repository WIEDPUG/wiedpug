using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.OrganizationDetailsAggregate
{
    public class OrganizationDetails
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        [Required]
        public required List<OrganizationDetail> OrganizationDetailCollection { get; set; }
    }
}
