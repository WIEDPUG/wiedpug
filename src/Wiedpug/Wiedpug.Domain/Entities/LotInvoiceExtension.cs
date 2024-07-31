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
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? GSTFirstCost { get; set; }

        /// <summary>
        /// Optional decimal field for GST on total post sale charge with two digits precision.
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? GSTTotalPostSaleCharge { get; set; }

        /// <summary>
        /// Required decimal field for total post sale charge with two digits precision.
        /// </summary>
        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency TotalPostSaleCharge { get; set; }

        /// <summary>
        /// Optional decimal field for total post sale charge rebate with two digits precision.
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? TotalPostSaleChargeRebate { get; set; }

        /// <summary>
        /// Optional decimal field for GST on total post sale charge rebate with two digits precision.
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? GSTTotalPostSaleChargeRebate { get; set; }

    }
}
