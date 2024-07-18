using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.ValueObject
{
    public class QualitySchemeDetail
    {
        [MinLength(1)]
        [MaxLength(4)]
        public QualityScheme? QualityScheme { get; set; } // FIELD NUMBER 3 - Quality Scheme-1 - Start: 4, Size: 4, Data Type: ID, Justification: L, Requirement Designator: O

        /// <summary>
        /// Registered Identification issued by the relevant Accreditation or Membership organisation.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(8)]
        public string? QualitySchemeRegistrationId { get; set; } // FIELD NUMBER 4 - Quality Scheme RegistrationID-1 - Start: 8, Size: 8, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// Used to transmit (other) information relevant to the Scheme that is required by the buyer(e.g.Month/Year shorn).
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(13)]
        public string? QualitySchemeOtherDetail { get; set; } // FIELD NUMBER 5 - Quality Scheme Other Detail-1 - Start: 16, Size: 13, Data Type: AN, Justification: L, Requirement Designator: O
    }
}
