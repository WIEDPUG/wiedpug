using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class PaymentSummary
    {
        /// <summary>
        /// Required decimal field for the last cost paid with two digits precision.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double LastCostPaid { get; set; }

        /// <summary>
        /// Required decimal field for discount amount with two digits precision.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double DiscountAmount { get; set; }

        /// <summary>
        /// Required decimal field for net amount paid with two digits precision.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double NetAmountPaid { get; set; }

        /// <summary>
        /// Required date field for the date payment was made.
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string DatePaymentMade { get; set; }
    }

}