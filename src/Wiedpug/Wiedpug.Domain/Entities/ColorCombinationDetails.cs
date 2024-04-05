﻿using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class ColorCombinationDetails
    {
        [Required]
        public required string CertificateIdentity { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double Charge { get; set; }

        [Required]
        public required string Laboratory { get; set; }

        public int? RegrabSampleWeight { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? ColourX { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? ColourXMinimum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? ColourXMaximum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? ColourY { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? ColourYMinimum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? ColourYMaximum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? ColourZ { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? ColourZMimimum { get; set; }


        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? ColourZMaximum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? ColourYZ { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? ColourYZMinimum { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? ColourYZMaximum { get; set; }

        [Required]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [Required]
        public required CalibrationFlag CalibrationFlag { get; set; }

        /// <summary>
        /// Date value in ISO 8601 standard. e.g. 2024-03-21
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string DateIssued { get; set; }
    }
}