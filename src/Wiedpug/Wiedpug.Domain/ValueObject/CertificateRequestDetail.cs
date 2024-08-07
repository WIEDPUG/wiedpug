﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class CertificateRequestDetail
    {
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity {  get; set; }

        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public double Woolbase {  get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required Laboratory Laboratory { get; set; }
    }
}
