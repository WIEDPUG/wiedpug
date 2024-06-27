using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.TextAggregate
{
    public class Text
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        public List<Organisation>? FinalReceiverList { get; set; }

        [Required]
        public required List<Comment> Comments { get; set; }
    }
}
