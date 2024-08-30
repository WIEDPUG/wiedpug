using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class CountermarkHeadmark
    {
        /// <summary>
        /// The text to be applied as a countermark or headmark
        /// </summary>
        [MinLength(1)]
        [MaxLength(30)]
        public string? CountermarkHeadmarkLine1 { get; set; }

        /// <summary>
        /// The text to be applied as a countermark or headmark
        /// </summary>
        [MinLength(1)]
        [MaxLength(30)]
        public string? CountermarkHeadmarkLine2 { get; set; }
    }

}
