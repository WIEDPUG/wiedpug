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
        /// Goods & Services Tax Amount applicable to First Cost
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? GSTFirstCost { get; set; }

        /// <summary>
        /// Goods & Services Tax Amount applicable to Total Post Sale Charge
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
        /// The total (extended) amount of Post Sale Charge Rebate for the Lot. This value is provided where a value in the Post Sale Charge Rebate field exists
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? TotalPostSaleChargeRebate { get; set; }

        /// <summary>
        /// The total (extended) GST amount payable on the Post Sale Charge Rebate for the Lot.
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? GSTTotalPostSaleChargeRebate { get; set; }

    }
}
