using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class MiscellaneousCharge
    {
        /// <summary>
        /// Optional enum type for charge type.
        /// </summary>
        /// 
        [StringLength(5)]
        public ChargeType? ChargeType { get; set; }

        /// <summary>
        /// Optional alphanumeric field for charge description.
        /// </summary>
        /// 
        [StringLength(40)]
        public string? ChargeDescription { get; set; }

        /// <summary>
        /// Required enum type for currency.
        /// </summary>
        [Required]
        [StringLength(3)]
        public required Currency Currency { get; set; }

        /// <summary>
        /// Required decimal field for charge amount with two digits precision.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_12_2)]
        public required double ChargeAmount { get; set; }

        /// <summary>
        /// Required enum type for indicating debit or credit.
        /// </summary>
        [Required]
        [StringLength(1)]
        public required DebitCreditFlag DebitCreditFlag { get; set; }
    }


}