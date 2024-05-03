using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.TestRequestsVerificationAggregate
{
    public class TestRequestsVerification

    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        public List<TestRequestsVerificationDetail>? TestRequestsVerificationDetails { get; set; }

    }
}
