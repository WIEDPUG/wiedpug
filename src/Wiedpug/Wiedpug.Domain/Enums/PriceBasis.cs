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
        [Description("Greasy: Code: G. Greasy")]
        Greasy,

        [Description("CLCOF: Code: C. CLCOF (ACOF or NZCOF)")]
        CLCOF,

        [Description("CIF: Code: I. CIF")]
        CIF,

        [Description("FOB: Code: F. FOB")]
        FOB
    }
}
