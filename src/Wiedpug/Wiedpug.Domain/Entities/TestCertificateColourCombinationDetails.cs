﻿using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class TestCertificateColourCombinationDetails
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

        [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; }

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
        [MinLength(1)]
        [MaxLength(10)]
        public required string DateIssued { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required CalibrationFlag CalibrationFlag { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }        
    }
}