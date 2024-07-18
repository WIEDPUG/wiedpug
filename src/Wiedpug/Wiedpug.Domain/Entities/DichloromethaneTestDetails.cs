using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class DichloromethaneTestDetails
    {
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_6_2)]
        public required double Charge { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required string Laboratory { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? RegrabSampleWeight { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required RetestFlag RetestFlag { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public required double DichloromethaneDryBasis { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string DateIssued { get; set; }
    }
}
