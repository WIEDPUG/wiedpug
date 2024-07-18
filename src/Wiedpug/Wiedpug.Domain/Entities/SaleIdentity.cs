using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class SaleIdentity
    {
        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required SellingCentreType SellingCentreType { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int SaleNumber { get; set; }
    }
}