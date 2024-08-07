﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [Description("The code for a Test House.")]
    public enum Laboratory
    {
        [Description("1: Australian Wool Testing Authority")]
        AustralianWoolTestingAuthority = 1,

        [Description("2: N.Z. Wool Testing Authority")]
        NZWoolTestingAuthority = 2,

        [Description("3: N.Z. Wool Testing Service")]
        NZWoolTestingService = 3,

        [Description("4: South African Wool Testing Authority")]
        SouthAfricanWoolTestingAuthority = 4
    }
}
