using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Shared.Constants
{
    public class RegexPattern
    {
        public const string DATE_ISO8601 = "/^[0-9]{2}[0-9]{2}[0-9]{2}$/";
        public const string DATE_AND_TIME_WITH_TIMEZONE_ISO8601 = "/^(?:19|20)\\d{2}-(?:0[1-9]|1[0-2])-(?:0[1-9]|[12]\\d|3[01])T(?:[01]\\d|2[0-3]):[0-5]\\d:[0-5]\\d(?:Z|-0[1-9]|-1\\d|-2[0-3]|-00:?(?:0[1-9]|[1-5]\\d)|\\+[01]\\d|\\+2[0-3])(?:|:?[0-5]\\d)$/gm";
    }
}
