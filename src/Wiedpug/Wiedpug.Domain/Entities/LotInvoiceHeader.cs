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
    public class LotInvoiceHeader
    {
        /// <summary>
        /// Required alphanumeric field for lot identity.
        /// </summary>
        [Required]
        public required string LotIdentity { get; set; }

        /// <summary>
        /// Required numeric field for the number of bales.
        /// </summary>
        [Required]
        public required int Bales { get; set; }

        /// <summary>
        /// Required numeric field for gross weight.
        /// </summary>
        [Required]
        public required int Gross { get; set; }

        /// <summary>
        /// Required numeric field for tare weight.
        /// </summary>
        [Required]
        public required int Tare { get; set; }

        /// <summary>
        /// Optional numeric field for regrab sample weight.
        /// </summary>
        public int? RegrabSampleWeight { get; set; }

        /// <summary>
        /// Required numeric field for cost per weight unit.
        /// </summary>
        [Required]
        public required int CostPerWeightUnit { get; set; }

        /// <summary>
        /// Required decimal field for first cost with two digits precision.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double FirstCost { get; set; }

        /// <summary>
        /// Optional numeric field for clean weight.
        /// </summary>
        public int? CleanWeight { get; set; }

        /// <summary>
        /// Optional enum type for yield type.
        /// </summary>
        public YieldType? YieldType { get; set; }

        /// <summary>
        /// Optional alphanumeric field for client's cross reference.
        /// </summary>
        public string? ClientsCrossReference { get; set; }

        /// <summary>
        /// Optional alphanumeric field for wool description.
        /// </summary>
        public string? WoolDescription { get; set; }

        /// <summary>
        /// Required enum type for pack material.
        /// </summary>
        [Required]
        public required PackMaterial PackMaterial { get; set; }

    }
}
