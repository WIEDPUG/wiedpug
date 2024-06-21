using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class LotPaymentDetail
    {
        /// <summary>
        /// Required alphanumeric field for the first lot identity.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required string LotIdentity { get; set; }

        /// <summary>
        /// Required decimal field for the last cost of the first lot with two digits precision.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_12_2)]
        public required double LotLastCost { get; set; }
    }

}