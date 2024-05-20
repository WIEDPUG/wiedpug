using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [Description("Where a line/lot contains a Pack with a lower Material, the lower Material shall apply.The hierarchy from highest to lowest is N, E, J, K. " +
        "Printed catalogue condition: The code for Nylon packs shall not be printed (but shall be transmitted).")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PackMaterial
    {
        [Description("N: Nylon Packs (complete lots only)")]
        N,

        [Description("E: Experimental Packs")]
        E,

        [Description("J: Jute packs (complete lots or lots that contain portions of Nylon and/or HDPE 5 and/or HDPE 1 and Jute packs)")]
        J,

        [Description("K: HDPE1 packs (complete lots or lots that contain portions of Nylon and/or HDPE 5 and HDPE 1 packs)")]
        K
    }
}
