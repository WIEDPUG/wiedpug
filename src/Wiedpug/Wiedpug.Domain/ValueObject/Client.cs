using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.ValueObject
{
    public class Client
    {
        public string? OrganizationCode { get; set; }
        public Centre? Centre { get; set; }
        public string? OrganizationID { get; set; }
    }
}
