using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class Yield
    {
        [MinLength(1)]
        [MaxLength(2)]
        public YieldType? YieldType { get; set; }

        /// <summary>
        /// The amount of recoverable fibre from a lot under set processing conditions
        /// </summary>
        [Range(-999.99,999.99)]
        public double? YieldValue { get; set; }

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        public Weight? CleanWeight { get; set; }
    }
}
