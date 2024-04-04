﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class Bale
    {
        public required BaleHeader BaleHeader { get; set; }

        public List<BaleDetail>? BaleDetails { get; set; }
    }
}
