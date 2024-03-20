using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("A code to indicate which section of the sale that lot belongs.")]
    public enum WoolTypeGroup
    {
        [Description("MFLC: Merino fleece types")]
        MFLC,

        [Description("MSKT: Merino fleece types")]
        MSKT,

        [Description("XBFS: Merino fleece types")]
        XBFS,

        [Description("ODDS: Merino fleece types")]
        ODDS
    }
}
