using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.ValueObject
{
    public class BaleIdentification
    {
        [Required]
        public required string BaleNumber { get; set; }

        public string? EBaleID { get; set; }
    }
}
