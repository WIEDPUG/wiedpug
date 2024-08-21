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
    }
}
