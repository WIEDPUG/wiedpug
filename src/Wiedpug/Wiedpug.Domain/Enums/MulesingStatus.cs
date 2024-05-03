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
        [Description("NonMulesed: Code: NM. Non Mulesed")]
        NonMulesed,

        [Description("LiquidNitrogen: Code: LN. Liquid Nitrogen")]
        LiquidNitrogen,

        [Description("CeasedMulesing: Code: CM. Ceased Mulesing")]
        CeasedMulesing,

        [Description("MulesedWithAnalgesicAndOrAnaesthetic: Code: AA. Mulesed with Analgesic &/or Anaesthetic")]
        MulesedWithAnalgesicAndOrAnaesthetic,

        [Description("Mulesed: Code: M. Mulesed")]
        Mulesed,

        [Description("NotDeclared: Code: ND. Not Declared")]
        NotDeclared
    }
}
