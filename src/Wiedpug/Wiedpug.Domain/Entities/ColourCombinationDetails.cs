using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class ColourCombinationDetails
    {
        [Required]
        [StringLength(11)]
        public required string CertificateIdentity { get; set; }
        
        [RegularExpression(RegexPattern.DECIMAL_6_2)]
        public double? Charge { get; set; }

        [Required]
        [StringLength(1)]
        public required Laboratory Laboratory { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? RegrabSampleWeight { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? ColourX { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? ColourXMinimum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? ColourXMaximum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? ColourY { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? ColourYMinimum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? ColourYMaximum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? ColourZ { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? ColourZMimimum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_3_1)]
        public double? ColourZMaximum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_4_1)]
        public double? ColourYZ { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_4_1)]
        public double? ColourYZMinimum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_4_1)]
        public double? ColourYZMaximum { get; set; }

        /// <summary>
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [StringLength(10)]
        public required string DateIssued { get; set; }

        [Required]
        [StringLength(1)]
        public required CalibrationFlag CalibrationFlag { get; set; }

        [Required]
        [StringLength(1)]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }        
    }
}
