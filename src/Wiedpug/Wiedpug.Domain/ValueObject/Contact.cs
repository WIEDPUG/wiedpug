﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.ValueObject
{
    public class Contact
    {
        [StringLength(80)]
        public string? Description { get; set; }

        [StringLength(80)]
        public string? FirstName { get; set; }

        [StringLength(80)]
        public string? LastName { get; set; }

        public PhoneNumber? PhoneNumber { get; set; }

        public PhoneNumber? MobileNumber { get; set; }

        [EmailAddress]
        [StringLength(80)]
        public string? Email { get; set; }
    }
}
