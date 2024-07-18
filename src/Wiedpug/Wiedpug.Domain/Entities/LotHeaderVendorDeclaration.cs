using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class LotHeaderVendorDeclaration
    {
        public List<QualitySchemeDetail>? QualitySchemes { get; set; }

        [MinLength(1)]
        [MaxLength(2)]
        public MulesingStatus? MulesingStatus { get; set; } // FIELD NUMBER 12 - Mulesing Status - Start: 79, Size: 2, Data Type: ID, Justification: L, Requirement Designator: C

    }
}
