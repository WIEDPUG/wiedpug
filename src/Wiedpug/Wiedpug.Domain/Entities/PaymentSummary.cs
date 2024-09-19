using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class PaymentSummary
    {
        /// <summary>
        /// Required decimal field for the last cost paid with two digits precision.
        /// </summary>
        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency LastCostPaid { get; set; }

        /// <summary>
        /// Required decimal field for discount amount with two digits precision.
        /// </summary>
        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency DiscountAmount { get; set; }

        /// <summary>
        /// Required decimal field for net amount paid with two digits precision.
        /// </summary>
        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency NetAmountPaid { get; set; }

        /// <summary>
        /// Required date field for the date payment was made.
        /// </summary>
        [Required]
        public required UtcDate DatePaymentMade { get; set; }
    }

}