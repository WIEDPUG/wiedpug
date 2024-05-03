using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WeightUnit
    {
        [Description("Kilograms: Code: 0. Kilograms")]
        Kilograms = 0,

        [Description("Pounds: Code: 1. Pounds")]
        Pounds = 1        
    }
}
