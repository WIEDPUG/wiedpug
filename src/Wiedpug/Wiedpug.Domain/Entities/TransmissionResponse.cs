using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class TransmissionResponse
    {
        [Range(-9999,9999)]
        public int? RecordNumber { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// A free form message
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(69)]
        public required string Text { get; set; }

    }
}
