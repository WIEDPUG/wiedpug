using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class SaleIdentity
    {
        [StringLength(2)]
        public string? SellingCentreType { get; set; }

        [StringLength(2)]
        [RegularExpression(Regex.NUMBERS)]
        public string? SaleNumber { get; set; }
    }
}