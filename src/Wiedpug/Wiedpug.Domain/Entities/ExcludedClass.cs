using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class ExcludedClass
    {
        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public required ClassToBeExcluded ClassToBeExcluded { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public SubClassToBeExcluded? SubClassToBeExcluded { get; set; }
    }
}
