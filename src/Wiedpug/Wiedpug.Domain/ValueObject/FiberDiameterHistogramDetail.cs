using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class FibreDiameterHistogramDetail
    {
        /// <summary>
        /// Fibre Diameter for the measurement.
        /// </summary>
        [Required]
        public required int FibreDiameter { get; set; }

        /// <summary>
        /// Percentage of fibres measured for the measurement.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_FOUR_DIGITS)]
        public required decimal FibresMeasured { get; set; }

    }
}
