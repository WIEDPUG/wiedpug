using System.ComponentModel.DataAnnotations;

namespace Wiedpug.Domain.Entities
{
    public class TransmissionResponse
    {
        public int? RecordNumber { get; set; }
        public string? ErrorCode { get; set; }
        [Required]
        public required string Text { get; set; }

    }
}
