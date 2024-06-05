using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class TransmissionResponse
    {
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public int? RecordNumber { get; set; }

        [StringLength(5)]
        public string? ErrorCode { get; set; }

        [Required]
        [StringLength(69)]
        public required string Text { get; set; }

    }
}
