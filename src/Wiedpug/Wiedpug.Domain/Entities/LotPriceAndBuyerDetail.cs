using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class LotPriceAndBuyerDetail
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
        public required LotIdentity LotIdentity { get; set; }

        /// <summary>
        /// The selling price per weight unit. Generally, cost per weight unit will be in Australian cents per kilogram.
        /// </summary>
        [Required]
        [Range(-999999,999999)]
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
        /// The auction room time the lot was passed in, sold or withdrawn (unverified data).
        ///
        /// Date and Time value in ISO 8601 standard UTC format. e.g. 2024-03-21T19:25:04Z
        /// </summary>
        [Required]
        public required UtcDateTime AuctionSaleTime { get; set; }
    }
}