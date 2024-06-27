using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.TextAggregate
{
    public class Texts
    {
        [Required]
        public required List<Text> TextList { get; set; }
    }
}
