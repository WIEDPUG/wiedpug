using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class PriceAndBuyerDetail
    {
        /// <summary>
        /// Required alphanumeric field for lot identity.
        /// </summary>
        [Required]
        [StringLength(6)]
        public required string LotIdentity { get; set; }

        /// <summary>
        /// Required numeric field for cost per weight unit.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        [StringLength(6)]
        public required int CostPerWeightUnit { get; set; }

        /// <summary>
        /// Required generic string field for buying organisation.
        /// </summary>
        [Required]
        [StringLength(8)]
        public required Organisation BuyingOrganisation { get; set; }

        /// <summary>
        /// Required enum type for sale outcome.
        /// </summary>
        [Required]
        [StringLength(1)]
        public required SaleOutcome SaleOutcome { get; set; }

        /// <summary>
        /// Required Time field for auction sale time.
        /// </summary>
        [Required]
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [StringLength(20)]
        public required string AuctionSaleTime { get; set; }
    }
}