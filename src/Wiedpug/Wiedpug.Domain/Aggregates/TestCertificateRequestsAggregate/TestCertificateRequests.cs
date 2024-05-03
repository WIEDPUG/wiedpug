using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates
{
    public class TestCertificateRequests

    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; } //31
                        
        public List<TestCertificateRequest>? TestCertificateRequestCollection { get; set; } //32A

    }
}
