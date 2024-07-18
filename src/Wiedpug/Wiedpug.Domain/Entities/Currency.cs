using System;
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
    public class Currency
    {
        /// <summary>
        /// Total up to 12 digits with 2 digits after the decimal point.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_12_2)]
        public required double Value { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        public CurrencyUnit? CurrencyUnit { get; set; }
    }
}
