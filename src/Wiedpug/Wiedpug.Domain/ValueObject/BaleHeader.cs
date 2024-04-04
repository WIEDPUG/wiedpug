using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.ValueObject
{
    public class BaleHeader
    {
        [Required]
        public required string Brand { get; set; }

        [Required]
        public required string BaleDescription { get; set; }

        [Required]
        public required string AreaOfOrigin { get; set; }

        public string? LocationWithinStore { get; set; }
    }
}
