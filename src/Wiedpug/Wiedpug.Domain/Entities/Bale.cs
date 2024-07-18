using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class Bale
    {
        [Required]
        public required BaleHeader BaleHeader { get; set; }

        public List<BaleDetail>? BaleDetails { get; set; }

        /// <summary>
        /// Property Identification Code - the property code to identify the source of the wool.
        /// This field is not used in New Zealand transmission.
        /// For TRV only
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(8)]
        public List<string>? PropertyIdentificationCodes { get; set; }
    }
}
