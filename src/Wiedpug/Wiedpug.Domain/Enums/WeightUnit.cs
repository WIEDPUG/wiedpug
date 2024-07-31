using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    public enum WeightUnit
    {
        [Description("0: Kilograms")]
        Kilograms = 0,

        [Description("1: Pounds")]
        Pounds = 1,

        [Description("2: Grams")]
        Grams = 2
    }
}
