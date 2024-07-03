﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.ValueObject
{
    public class TestCertificateBaleHeader
    {
        [Required]
        [StringLength(30)]
        public required string Brand { get; set; }

        [Required]
        [StringLength(15)]
        public required string BaleDescription { get; set; }

        [Required]
        [StringLength(4)]
        public required string AreaOfOrigin { get; set; }

        [StringLength(20)]
        public string? LocationWithinStore { get; set; }
    }
}
