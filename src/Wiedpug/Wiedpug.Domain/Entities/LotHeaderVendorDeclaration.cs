using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class LotHeaderVendorDeclaration
    {        
        public QualitySchemeDetail? QualityScheme1 { get; set; }
        public QualitySchemeDetail? QualityScheme2 { get; set; }
        public QualitySchemeDetail? QualityScheme3 { get; set; }
        /// <summary>
        /// This field is mandatory in Australia and optional outside Australia.
        /// </summary>
        public string? MulesingStatus { get; set; } // FIELD NUMBER 12 - Mulesing Status - Start: 79, Size: 2, Data Type: ID, Justification: L, Requirement Designator: C

    }
}
