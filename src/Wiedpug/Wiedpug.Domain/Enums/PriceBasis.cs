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
    public enum PriceBasis
    {
        [Description("G: Greasy")]
        G,

        [Description("C: CLCOF (ACOF or NZCOF)")]
        C,

        [Description("I: CIF")]
        I,

        [Description("F: FOB")]
        F
    }
}
