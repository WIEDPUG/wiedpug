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
        [MinLength(1)]
        [MaxLength(5)]
        public ChargeType? ChargeType { get; set; }

        /// <summary>
        /// Optional alphanumeric field for charge description.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(40)]
        public string? ChargeDescription { get; set; }

        /// <summary>
        /// Required enum type for currency.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(3)]
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
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitCreditFlag DebitCreditFlag { get; set; }
    }


}