using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class Balance
    {
        [Required]
        public required BalanceType BalanceType { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DebitOrCreditFlag DebitOrCreditFlag { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency BalanceValue { get; set; }
    }

}