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
        public required string CertificateIdentity { get; set; }

        [Required]
        public required string Laboratory { get; set; }

        public int? LACBarbe { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? LACBarbeCV { get; set; }

        public double? LACHauteur { get; set; }

        public double? LACHauteurCV { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? LACCardWaste { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double Charge { get; set; }
    }
}
