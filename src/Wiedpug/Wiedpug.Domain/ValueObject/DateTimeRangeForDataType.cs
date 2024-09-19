using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class DateTimeRangeForDataType
    {
        public UtcDateTime? StartDateTime { get; set; }

        public UtcDateTime? EndDateTime { get; set; }
    }
}
