using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class LengthAfterCardingTestDetail
    {
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required Laboratory Laboratory { get; set; }

        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? LacBarbe { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_4_1)]
        public double? LacBarbeCvPercentage { get; set; }

        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? LacHauteur { get; set; }

        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? LacHauteurCvPercentage { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? LacCardWastePercentage { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency Charge { get; set; }
    }
}
