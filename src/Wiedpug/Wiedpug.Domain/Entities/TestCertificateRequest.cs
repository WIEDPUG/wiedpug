using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class TestCertificateRequest

    {
        [Required]
        public required CertificateRequest CertificateRequest { get; set; }

        public BaleHeader? BaleHeader { get; set; }

    }
}
