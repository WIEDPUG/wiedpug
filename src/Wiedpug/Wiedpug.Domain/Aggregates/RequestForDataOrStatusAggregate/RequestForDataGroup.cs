using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.AggregatesModel.RequestForDataOrStatusAggregate
{
    public class RequestForDataGroup
    {
        [Required]
        public required TransmissionHeader TransmissionHeader{ get; set; }

        [Required]
        public required List<RequestForData> RequestForDataCollection { get; set; }
    }
}