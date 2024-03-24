using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.AggregatesModel.RequestForDataOrStatusAggregate
{
    public class RequestForDataGroup
    {
        public TransmissionHeader TransmissionHeader{ get; set; }

        [Required]        
        public List<RequestForData> RequestForDataCollection { get; set; }
    }
}