using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class DichloromethaneTestDetail
    {
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency Charge { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required Laboratory Laboratory { get; set; }

        /// <summary>
        /// The weight of a regrab sample, a grab sample taken after the wool has been initially sampled and tested, is shown on the new certificate.
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required RetestFlag RetestFlag { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        /// <summary>
        /// Dichloromethane Extractable Matter (Residual Grease) remaining in a sample of wool after scouring and drying.
        ///
        /// Min: The lowest value in a range of Dichloromethane, dry basis values
        ///
        /// Max: The highest value in a range of Dichloromethane, dry basis values
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public required double DichloromethaneDryBasis { get; set; }

        /// <summary>
        /// The date the certificate was issued.
        /// 
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string DateIssued { get; set; }
    }
}
