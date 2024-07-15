using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class Currency
    {
        [Required]
        public required double Value { get; set; }

        [StringLength(3)]
        public CurrencyCode? CurrencyCode { get; set; }
    }
}
