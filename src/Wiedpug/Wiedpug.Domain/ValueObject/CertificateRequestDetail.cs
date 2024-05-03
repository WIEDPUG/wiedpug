using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.ValueObject
{
    public class CertificateRequestDetail
    {
        [Required]
        public required string CertificateIdentity {  get; set; }
        
        public double Woolbase {  get; set; }

        [Required]
        public required Laboratory Laboratory { get; set; }
    }
}
