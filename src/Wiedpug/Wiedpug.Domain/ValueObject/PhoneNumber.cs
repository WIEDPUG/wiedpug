using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.ValueObject
{
    public class PhoneNumber
    {
        public required string CountryCode { get; set; }
        public required string Number { get; set; }

    }
}
