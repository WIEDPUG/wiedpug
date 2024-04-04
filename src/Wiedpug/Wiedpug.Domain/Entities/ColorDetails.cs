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
    public class ColorDetails
    {
        [Required]
        public required string CertificateIdentity { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required decimal Charge { get; set; }

        [Required]
        public required string Laboratory { get; set; }

        public int? RegrabSampleWeight { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public required decimal ColourX { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public required decimal ColourY { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public required decimal ColourZ { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public decimal? ColourYZ { get; set; }

        public string? CoreBulkValue { get; set; }

        [Required]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public decimal ColourXAsIs { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public decimal ColourYAsIs { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public decimal ColourZAsIs { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public decimal? ColourYZAsIs { get; set; }

        [Required]
        public CalibrationFlag CalibrationFlag { get; set; }

        /// <summary>
        /// Date value in ISO 8601 standard. e.g. 2024-03-21
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string DateIssued { get; set; }
    }
}
