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
    public class ClassForOneOfReferencesToBeDeleted
    {
        public UseNetworkDateTimeRequestForDataType? UseNetworkDateTimeRequestForDataType { get; set; }

        public DateTimeRangeRequestForDataType? DateTimeRangeRequestForDataType { get; set; }
    }
}
