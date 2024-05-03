﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class ContractLimitRequirements
    {
        /// <summary>
        /// Minimum micron, optional decimal with one digit precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? MicronMin { get; set; }

        /// <summary>
        /// Maximum micron, optional decimal with one digit precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? MicronMax { get; set; }

        /// <summary>
        /// Minimum colour Y-Z, optional decimal with one digit precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? ColourYZMin { get; set; }

        /// <summary>
        /// Maximum colour Y-Z, optional decimal with one digit precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGIT)]
        public double? ColourYZMax { get; set; }

        /// <summary>
        /// Minimum VMB, optional decimal with two digits precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? VMBMin { get; set; }

        /// <summary>
        /// Maximum VMB, optional decimal with two digits precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? VMBMax { get; set; }

        /// <summary>
        /// Minimum wool base, optional decimal with two digits precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? WoolBaseMin { get; set; }

        /// <summary>
        /// Maximum wool base, optional decimal with two digits precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? WoolBaseMax { get; set; }

        /// <summary>
        /// Minimum dichloromethane on a dry basis, optional decimal with two digits precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? DichloromethaneDryBasisMin { get; set; }

        /// <summary>
        /// Maximum dichloromethane on a dry basis, optional decimal with two digits precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? DichloromethaneDryBasisMax { get; set; }

        /// <summary>
        /// Minimum conditioning mass, optional numeric field.
        /// </summary>
        public int? ConditioningMassMin { get; set; }

        /// <summary>
        /// Maximum conditioning mass, optional numeric field.
        /// </summary>
        public int? ConditioningMassMax { get; set; }

        /// <summary>
        /// Minimum LAC Barbe, optional numeric field.
        /// </summary>
        public int? LACBarbeMin { get; set; }

        /// <summary>
        /// Maximum LAC Barbe, optional numeric field.
        /// </summary>
        public int? LACBarbeMax { get; set; }

        /// <summary>
        /// Minimum LAC Hauteur, optional numeric field.
        /// </summary>
        public int? LACHauteurMin { get; set; }

        /// <summary>
        /// Maximum LAC Hauteur, optional numeric field.
        /// </summary>
        public int? LACHauteurMax { get; set; }

        /// <summary>
        /// Minimum LAC Hauteur under 20, optional numeric field.
        /// </summary>
        public int? LACHauteurUnder20Min { get; set; }

        /// <summary>
        /// Maximum LAC Hauteur under 20, optional numeric field.
        /// </summary>
        public int? LACHauteurUnder20Max { get; set; }

        /// <summary>
        /// Minimum LAC Hauteur under 40, optional numeric field.
        /// </summary>
        public int? LACHauteurUnder40Min { get; set; }

        /// <summary>
        /// Maximum LAC Hauteur under 40, optional numeric field.
        /// </summary>
        public int? LACHauteurUnder40Max { get; set; }

        /// <summary>
        /// Minimum LAC Hauteur CV(%), optional numeric field.
        /// </summary>
        public int? LACHauteurCVPercentMin { get; set; }

        /// <summary>
        /// Maximum LAC Hauteur CV(%), optional numeric field.
        /// </summary>
        public int? LACHauteurCVPercentMax { get; set; }
    }


}
