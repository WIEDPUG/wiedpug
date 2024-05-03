using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.TestStatusAggregate
{
    public class TestStatus

    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        public List<TestStatusDetail>? TestStatusDetails { get; set; }

    }
}
