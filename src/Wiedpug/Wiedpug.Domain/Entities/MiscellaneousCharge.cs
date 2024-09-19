using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class MiscellaneousCharge
    {
        /// <summary>
        /// A code describing a charge such as penalty interest or miscellaneous adjustments to an earlier payment.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(5)]
        public string? ChargeType { get; set; }

        /// <summary>
        /// A description of the particular charge type.
        /// </summary>
        [MinLength(1)]
        [MaxLength(40)]
        public string? ChargeDescription { get; set; }

        /// <summary>
        /// Required decimal field for charge amount with two digits precision.
        /// </summary>
        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency ChargeAmount { get; set; }

        /// <summary>
        /// Required enum type for indicating debit or credit.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitOrCreditType DebitOrCreditType { get; set; }
    }


}