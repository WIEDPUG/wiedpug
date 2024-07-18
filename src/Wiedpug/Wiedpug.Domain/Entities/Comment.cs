using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class Comment
    {
        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public required string Text { get; set; }
    }
}
