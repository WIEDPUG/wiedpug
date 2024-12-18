using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.TestRequestsVerificationAggregate
{
    public class TestRequestsVerification

    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        /// <summary>
        /// Used to define document transfer type: unrestricted, restricted or exclusion.
        /// </summary>
        [Required]
        public required TransferConfig TransferConfig { get; set; }

        public List<TestRequestsVerificationDetail>? TestRequestsVerificationDetails { get; set; }

    }
}
