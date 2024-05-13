using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.ValueObject
{
    public class Contact
    {
        public string? Description { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public PhoneNumber? PhoneNumber { get; set; }

        public PhoneNumber? MobileNumber { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}
