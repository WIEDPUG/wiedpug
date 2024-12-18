using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates
{
    public class TestCertificateRequests

    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; } //31

        /// <summary>
        /// Used to define document transfer type: unrestricted, restricted or exclusion.
        /// </summary>
        [Required]
        public required TransferConfig TransferConfig { get; set; }

        public List<TestCertificateRequestDetail>? TestCertificateRequestDetails { get; set; } //32A

    }
}
