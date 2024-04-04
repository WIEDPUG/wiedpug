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
        [Description("Non Mulesed")]
        NM,
        [Description("Liquid Nitrogen")]
        LN,
        [Description("Ceased Mulesing")]
        CM,
        [Description("Mulesed with Analgesic &/or Anaesthetic")]
        AA,
        [Description("Mulesed")]
        M,
        [Description("Not Declared")]
        ND
    }
}
