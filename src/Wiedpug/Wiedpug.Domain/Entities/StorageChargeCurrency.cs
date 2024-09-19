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
    public class StorageChargeCurrency
    {
        [Required]
        [Range(-9.999,9.999)]
        public required double Value { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        public CurrencyCode? CurrencyCode { get; set; }
    }
}
