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

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public decimal? LACBarbeCV { get; set; }

        public decimal? LACHauteur { get; set; }

        public decimal? LACHauteurCV { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public decimal? LACCardWaste { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal Charge { get; set; }
    }
}
