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
    public class LotInvoiceExtension
    {
        /// <summary>
        /// Optional decimal field for GST on the first cost with two digits precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_12_2)]
        public double? GSTFirstCost { get; set; }

        /// <summary>
        /// Optional decimal field for GST on total post sale charge with two digits precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_12_2)]
        public double? GSTTotalPostSaleCharge { get; set; }

        /// <summary>
        /// Required decimal field for total post sale charge with two digits precision.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_12_2)]
        public required double TotalPostSaleCharge { get; set; }

        /// <summary>
        /// Optional decimal field for total post sale charge rebate with two digits precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_12_2)]
        public double? TotalPostSaleChargeRebate { get; set; }

        /// <summary>
        /// Optional decimal field for GST on total post sale charge rebate with two digits precision.
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_12_2)]
        public double? GSTTotalPostSaleChargeRebate { get; set; }

    }
}
