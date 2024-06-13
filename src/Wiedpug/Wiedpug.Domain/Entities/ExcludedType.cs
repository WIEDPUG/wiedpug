﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class ExcludedType
    {
        [Required]
        [StringLength(3)]
        public required RecordTypesToBeExcluded RecordTypesToBeExcluded { get; set; }

        [StringLength(1)]
        public SubTypeToBeExcluded? SubTypesToBeExcluded { get; set; }
    }
}