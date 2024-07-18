using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class PhoneNumber
    {
        /// <summary>
        /// Standard Phone number following E.164 standard, maximun of 15 digits
        /// https://en.wikipedia.org/wiki/E.164
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(15)]
        public required StandardPhoneNumber StandardPhoneNumber { get; set; }

        /// <summary>
        /// Used for landline or fax extentions
        /// </summary>
        [MinLength(1)]
        [MaxLength(15)]
        public string? Extension { get; set; }

    }
}
