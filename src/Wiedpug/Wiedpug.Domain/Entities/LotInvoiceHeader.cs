﻿using System;
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
    public class LotInvoiceHeader
    {
        /// <summary>
        /// This is a compound name for lot number and lot suffix, where the lot 
        /// number is 5 numeric characters and the lot suffix is 1 alphanumeric
        /// character.The suffix is used when a lot is broken up by the original lot
        /// number is retained; for example.If 2 bales of a 10-bale lot got wet and
        /// the 8 bales and the 2 bales are offered separately, one could have a
        /// suffix A and the other a suffix B.Where a suffix is not used, the lot
        /// number occupies the whole of the Lot Identity field and is right justified.
        ///
        /// From:
        ///
        /// The current value that the Lot Identity is to be changed from.
        /// 
        /// To:
        /// 
        /// The new value that the Lot Identity is to be changed to.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(6)]
        public required string LotIdentity { get; set; }

        /// <summary>
        /// Required numeric field for the number of bales.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public required int Bales { get; set; }

        /// <summary>
        /// Required numeric field for gross weight.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight Gross { get; set; }

        /// <summary>
        /// Required numeric field for tare weight.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight Tare { get; set; }

        /// <summary>
        /// Optional numeric field for regrab sample weight.
        /// </summary>
        /// 
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; }

        /// <summary>
        /// Required numeric field for cost per weight unit.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required int CostPerWeightUnit { get; set; }

        /// <summary>
        /// Required decimal field for first cost with two digits precision.
        /// </summary>
        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency FirstCost { get; set; }

        /// <summary>
        /// Optional numeric field for clean weight.
        /// </summary>
        ///
        [MinLength(4)]
        [MaxLength(9)] 
        public Weight? CleanWeight { get; set; }

        /// <summary>
        /// Optional enum type for yield type.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(2)]
        public YieldType? YieldType { get; set; }

        /// <summary>
        /// Optional alphanumeric field for client's cross reference.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(8)]
        public string? ClientsCrossReference { get; set; }

        /// <summary>
        /// Optional alphanumeric field for wool description.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(20)]
        public string? WoolDescription { get; set; }

        /// <summary>
        /// Required enum type for pack material.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required PackMaterial PackMaterial { get; set; }

    }
}
