using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Wiedpug.Domain.Entities
{
    /// <summary>
    /// The certificate identity consists of a 1 digit prefix, followed by an 8 digit certificate number, followed by a 1 character suffix, followed by a 1 digit
    /// check number.It is printed at the top of the certificate.
    /// </summary>
    public class CertificateIdentity
    {
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required CertificateIdPrefix CertificateIdPrefix { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required int CertificateIdNumber { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required CertificateIdSuffix CertificateIdSuffix { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required int CertificateIdCd { get; set; }
    }
}
