﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class SoftwareIdentifier
    {
        [MinLength(1)]
        [MaxLength(1)]
        public SoftwareCompany SoftwareCompany { get; set; }

        /// <summary>
        /// Version no. e.g. 2400
        /// </summary>      
        /// 
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public int? Version { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        public string? ProgramName { get; set; }
    }
}
