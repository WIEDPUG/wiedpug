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
    public class LengthAfterCardingTestDetails
    {
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required string Laboratory { get; set; }

        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? LACBarbe { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_4_1)]
        public double? LACBarbeCV { get; set; }

        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? LACHauteur { get; set; }

        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? LACHauteurCV { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? LACCardWaste { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_6_2)]
        public required double Charge { get; set; }
    }
}
