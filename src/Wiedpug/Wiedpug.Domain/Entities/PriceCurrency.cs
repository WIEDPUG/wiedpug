using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class PriceCurrency
    {
        /// <summary>
        /// Total up to 12 digits with 2 digits after the decimal point of per unit cost. It is in cent.
        /// </summary>
        [Required]
        [Range(-999999,999999)]
        public required int Value { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        public CurrencyCode? CurrencyCode { get; set; }
    }
}
