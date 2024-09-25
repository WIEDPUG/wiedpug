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
    /// <summary>
    /// creditNoteAmount: Amount to be credited
    /// 
    /// gstAmount: Goods & Services Tax Amount
    /// 
    /// costPerWeightUnit: The selling price per weight unit. Generally, cost per weight unit will be in Australian cents per kilogram.
    /// 
    /// gstFirstCost: Goods & Services Tax Amount applicable to First Cost.
    /// 
    /// postSaleChargeRebate: The total (extended) amount of Post Sale Charge Rebate for the Lot.
    /// 
    /// gstTotalPostSaleCharge: Goods & Services Tax Amount applicable to Total Post Sale Charge.
    /// 
    /// totalPostSaleChargeRebate: The total (extended) amount of Post Sale Charge Rebate for the Lot. This value is provided where a value in the Post Sale Charge Rebate field exists.
    /// 
    /// lotLastCost: This is the sum of the following amount: First Cost + (Post sale charge X total bales) + charge per lot.
    /// 
    /// freightCharge: If specified, this is not part of the last cost of the wool. If a freight charge is not included in the post Sale Charge, then the freight charge is the charge levied by the broker should the buyer request that the broker transport the wool to the nearest designated area (usually a shipping port). Freight Charge is not used in Australia.
    /// 
    /// chargePerLot: Any charge made for a lot which is not covered by the Post Sale Charge or the Freight charge per Bale fields.
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Total up to 12 digits with 2 digits after the decimal point.
        /// </summary>
        [Required]
        [Range(-9999999999.99,9999999999.99)]
        public required double Value { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        public CurrencyCode? CurrencyCode { get; set; }
    }
}
