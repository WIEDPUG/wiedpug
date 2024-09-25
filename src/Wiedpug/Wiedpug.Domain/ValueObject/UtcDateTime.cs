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
    /// Date and Time value in ISO 8601 standard UTC datetime format. e.g. 2024-03-21T19:25:04+00:00.000Z
    /// 
    /// auctionSaleTime: The auction room time the lot was passed in, sold or withdrawn (unverified data).
    /// </summary>
    public class UtcDateTime
    {
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(20)]
        public string? DateTime { get; set; }


        //private readonly string _value;
        //private static readonly Regex _pattern = new Regex(RegexPattern.DATE_AND_TIME_UTC_ISO8601);

        //public UtcDateTime(string value)
        //{
        //    if (!IsValid(value))
        //    {
        //        throw new ArgumentException("Invalid UtcDateTime format.");
        //    }
        //    _value = value;
        //}

        //public static implicit operator UtcDateTime(string value) => new UtcDateTime{DateTime=value);
        //public static implicit operator string(UtcDateTime utcDateTime) => utcDateTime._value;

        //public override string ToString() => _value;

        //private static bool IsValid(string value)
        //{
        //    return _pattern.IsMatch(value);
        //}
    }
}
