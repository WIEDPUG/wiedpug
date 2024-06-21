using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class CertificateIdentity
    {
        [Required]
        [StringLength(1)]
        public required CertificateIDPrefix CertificateIDPrefix { get; set; }

        [Required]
        [StringLength(1)]
        public required CertificateIDSuffix CertificateIDSuffix { get; set; }

        [Required]
        [StringLength(8)]
        public required string CertificateIDNumber { get; set; }

        [Required]
        [StringLength(1)]
        public required int CertificateIDCD { get; set; }
    }
}
