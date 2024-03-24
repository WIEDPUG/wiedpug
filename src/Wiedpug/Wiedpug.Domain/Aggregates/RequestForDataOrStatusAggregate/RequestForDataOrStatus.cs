using System.ComponentModel.DataAnnotations;

namespace Wiedpug.Domain.AggregatesModel.RequestForDataOrStatusAggregate
{
    public class RequestForDataOrStatus
    {
        [Required]
        public List<RequestForDataGroup> Requests { get; set; }
    }
}
