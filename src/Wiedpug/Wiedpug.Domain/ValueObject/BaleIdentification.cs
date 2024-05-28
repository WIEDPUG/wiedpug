using System.ComponentModel.DataAnnotations;

namespace Wiedpug.Domain.ValueObject
{
    public class BaleIdentification
    {
        //gileto: I removed the [Required] flag because this is used in other Document Types.
        //Some require the first Bale Identification to be required and the rest are optional.
        //Removing the [Required] flag will increase its compatibility with other Document Types.
        [StringLength(5)]
        public string? BaleNumber { get; set; }

        [StringLength(30)]
        public string? EBaleId { get; set; }
    }
}
