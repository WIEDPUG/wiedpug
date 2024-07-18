using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.Errors
{
    public class BusinessError3
    {
        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public required ErrorCode ErrorCode { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public required string Text { get; set; }

        [MinLength(1)]
        [MaxLength(80)]
        public string? Reason { get; set; }

        [MinLength(1)]
        [MaxLength(80)]
        public string? Action { get; set; }
    }
}
