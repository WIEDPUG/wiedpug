using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    /// <summary>
    /// A code to describe the type of industry in which an organisation operates.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum IndustryGroupId
    {
        [Description("A: Agent / Broker")]
        A,

        [Description("C: Carrier")]
        C,

        [Description("E: Exporter / Buyer")]
        E,

        [Description("D: Dump")]
        D,

        [Description("M: Miscellaneous")]
        M,

        [Description("P: Port")]
        P,

        [Description("S: Shipping")]
        S,

        [Description("T: Test House")]
        T,

        [Description("V: Vessel")]
        V
    }
}
