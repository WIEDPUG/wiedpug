using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

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
