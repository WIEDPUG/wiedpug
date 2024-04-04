using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.OrganizationDetailsAggregate
{
    public class OrganizationDetails
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }
    }
}
