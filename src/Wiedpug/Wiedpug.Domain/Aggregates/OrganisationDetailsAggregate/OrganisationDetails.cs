﻿using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.OrganisationDetailsAggregate
{
    public class OrganisationDetails
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        [Required]
        public required List<OrganisationInformationDetail> OrganisationInformationDetails { get; set; }
    }
}
