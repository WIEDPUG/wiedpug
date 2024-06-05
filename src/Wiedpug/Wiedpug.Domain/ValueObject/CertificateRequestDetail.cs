using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class CertificateRequestDetail
    {
        [Required]
        [StringLength(11)]
        public required string CertificateIdentity {  get; set; }

        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public double Woolbase {  get; set; }

        [Required]
        [StringLength(1)]
        public required Laboratory Laboratory { get; set; }
    }
}
