using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.OrganizationDetailsAggregate
{
    public class OrganisationDetails
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        [Required]
        public required List<OrganisationDetail> OrganisationDetailCollection { get; set; }
    }
}
