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
    public enum WeightCode
    {
        [Description("KG: Kilograms")]
        KG = 0,

        [Description("LB: Pounds")]
        LB = 1,

        [Description("G: Grams")]
        G = 2
    }
}
