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
    public enum MulesingStatus
    {
        [Description("NM: Non Mulesed")]
        NM,

        [Description("LN: Liquid Nitrogen")]
        LN,

        [Description("CM: Ceased Mulesing")]
        CM,

        [Description("AA: Mulesed with Analgesic &/or Anaesthetic")]
        AA,

        [Description("M: Mulesed")]
        M,

        [Description("ND: Not Declared")]
        ND
    }
}
