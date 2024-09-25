using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wiedpug.Domain.ValueObject
{
    /// <summary>
    /// Number of bales
    /// </summary>
    public class NumberOfBales
    {
        [Range(-9999,9999)]
        public int? BalesCount { get; set; }
    }
}
