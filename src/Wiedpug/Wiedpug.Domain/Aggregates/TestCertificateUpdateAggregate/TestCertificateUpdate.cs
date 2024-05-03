using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.TestCertificateUpdateAggregate
{
    public class TestCertificateUpdate

    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        public List<TestCertificateUpdateDetail>? TestCertificateUpdateDetails { get; set; }

    }
}
