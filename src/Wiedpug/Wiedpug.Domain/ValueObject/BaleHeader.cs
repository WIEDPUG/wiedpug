using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class BaleHeader
    {
        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public required string Brand { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(15)]
        public required string BaleDescription { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(4)]
        public required string AreaOfOrigin { get; set; }

        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        [MinLength(1)]
        [MaxLength(4)]
        public int? Bales {  get; set; }

        [MinLength(1)]
        [MaxLength(20)]
        public string? LocationWithinStore { get; set; }
    }
}
