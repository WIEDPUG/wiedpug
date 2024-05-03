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
    public enum ScouredType
    {
        [Description("NotScoured: Code: 0. Not Scoured")]
        NotScoured = 0,

        [Description("ScouredAqueous: Code: 1. Scoured – Aqueous")]
        ScouredAqueous = 1,

        [Description("ScouredDualSolvent: Code: 2. Scoured – Dual Solvent")]
        ScouredDualSolvent = 2,

        [Description("Carbonised: Code: 3. Carbonised")]
        Carbonised = 3,

        [Description("Mohair: Code: 4. Mohair")]
        Mohair = 4,

        [Description("Noils: Code: 5. Noils")]
        Noils = 5,

        [Description("Slipe: Code: 6. Slipe")]
        Slipe = 6
    }
}
