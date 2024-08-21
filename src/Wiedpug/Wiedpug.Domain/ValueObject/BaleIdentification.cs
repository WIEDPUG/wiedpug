using System.ComponentModel.DataAnnotations;

namespace Wiedpug.Domain.ValueObject
{
    public class BaleIdentification
    {
        /// <summary>
        /// The number used to identify a bale in a lot
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public string? BaleNumber { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        public string? EBaleId { get; set; }
    }
}
