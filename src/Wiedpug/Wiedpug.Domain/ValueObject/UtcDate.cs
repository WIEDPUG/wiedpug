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
    /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD).
    /// </summary>  
    public class UtcDate
    {
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? Date { get; set; }
    }
}
