using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class LotPriceAndBuyerDetail
    {
        /// <summary>
        /// Required alphanumeric field for lot identity.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(6)]
        public required string LotIdentity { get; set; }

        /// <summary>
        /// Required numeric field for cost per weight unit.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        [MinLength(1)]
        [MaxLength(6)]
        public required int CostPerWeightUnit { get; set; }

        /// <summary>
        /// Required generic string field for buying organisation.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation BuyingOrganisation { get; set; }

        /// <summary>
        /// Required enum type for sale outcome.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required SaleOutcome SaleOutcome { get; set; }

        /// <summary>
        /// Required Time field for auction sale time.
        /// </summary>
        [Required]
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(20)]
        public required string AuctionSaleTime { get; set; }
    }
}