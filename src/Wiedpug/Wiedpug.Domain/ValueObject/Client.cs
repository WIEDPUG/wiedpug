using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.ValueObject
{
    public class Client
    {
        [StringLength(3)]
        public string? OrganizationCode { get; set; }

        [StringLength(5)]
        public Centre? Centre { get; set; }

        [StringLength(5)]
        public string? OrganizationID { get; set; }
    }
}
