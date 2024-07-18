using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class TransmissionResponse
    {
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public int? RecordNumber { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public string? ErrorCode { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(69)]
        public required string Text { get; set; }

    }
}
