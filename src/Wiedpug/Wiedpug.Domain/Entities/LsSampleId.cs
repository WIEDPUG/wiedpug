using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    /// <summary>
    /// Length and Strength test sample identification.
    /// </summary>
    /// 
    public class LsSampleId
    {
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required string Prefix { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_5_DIGITS)]
        public required int Number { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_1_DIGIT)]
        public required int CheckDigit { get; set; }
    }
}
