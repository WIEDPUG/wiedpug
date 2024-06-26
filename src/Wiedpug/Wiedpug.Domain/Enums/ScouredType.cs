using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    public enum ScouredType
    {
        [Description("0: Not Scoured")]
        NotScoured = 0,

        [Description("1: Scoured Aqueous")]
        ScouredAqueous = 1,

        [Description("2: Scoured Dual Solvent")]
        ScouredDualSolvent = 2,

        [Description("3: Carbonised")]
        Carbonised = 3,

        [Description("4: Mohair")]
        Mohair = 4,

        [Description("5: Noils")]
        Noils = 5,

        [Description("6: Slipe")]
        Slipe = 6
    }
}
