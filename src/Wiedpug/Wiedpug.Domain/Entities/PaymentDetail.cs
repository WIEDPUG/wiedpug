using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class PaymentDetail
    {
        [Required]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [StringLength(10)]
        public required string StatementDate { get; set; }

        [Required]
        [StringLength(11)]
        public required string AccountReference { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_9_2)]
        public required double Amount { get; set; }
        
        [Required]
        [StringLength(1)]
        public required PaymentType PaymentType { get; set;}

        [StringLength(30)]
        public string? Reason { get; set; }
    }

}