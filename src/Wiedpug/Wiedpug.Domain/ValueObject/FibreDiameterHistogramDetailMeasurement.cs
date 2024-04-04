using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class FibreDiameterHistogramDetailMeasurement
    {
        /// <summary>
        /// Micron Value
        /// </summary>
        [Required]
        public required int FibreDiameter { get; set; } // FIELD NUMBER 3 - Fibre Diameter-(1) - Start: 4, Size: 2, Data Type: N, Justification: R, Requirement Designator: M

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_POINT_FOUR)]
        public required double FibresMeasuredPercentage { get; set; } // FIELD NUMBER 4 - Fibres Measured (%)-(1) - Start: 6, Size: 6, Data Type: D4, Justification: R, Requirement Designator: M

    }
}
