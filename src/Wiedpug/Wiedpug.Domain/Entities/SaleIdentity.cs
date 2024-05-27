using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class SaleIdentity
    {
        [StringLength(2)]
        public string? SellingCentreType { get; set; }

        [StringLength(2)]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? SaleNumber { get; set; }
    }
}