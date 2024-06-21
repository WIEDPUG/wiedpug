﻿using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum CountermarkSize

    {
        [Description("3: 3 Inches")]
        ThreeInches = 3,

        [Description("4: 4 Inches")]
        FourInches = 4,

        [Description("6: 6 Inches")]
        SixInches = 6

    }
}
