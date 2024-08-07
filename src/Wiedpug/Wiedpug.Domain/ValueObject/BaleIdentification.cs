using System.ComponentModel.DataAnnotations;

namespace Wiedpug.Domain.ValueObject
{
    public class BaleIdentification
    {
        [MinLength(1)]
        [MaxLength(5)]
        public string? BaleNumber { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        public string? EBaleId { get; set; }
    }
}
