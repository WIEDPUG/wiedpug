using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class PaymentDetail
    {
        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string StatementDate { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required string AccountReference { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency Amount { get; set; }
        
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required PaymentType PaymentType { get; set;}

        [MinLength(1)]
        [MaxLength(30)]
        public string? Reason { get; set; }
    }

}