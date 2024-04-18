﻿using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class LotHeaderVendorDeclaration
    {
        [MaxLength(3)]
        public List<QualitySchemeDetail>? QualitySchemes { get; set; }        
        public string? MulesingStatus { get; set; } // FIELD NUMBER 12 - Mulesing Status - Start: 79, Size: 2, Data Type: ID, Justification: L, Requirement Designator: C

    }
}
