using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    public enum SourcedType
    {
        [Description("Not Scoured")]
        NotScoured = 0,

        [Description("Scoured – Aqueous")]
        ScouredAqueous = 1,

        [Description("Scoured – Dual Solvent")]
        ScouredDualSolvent = 2,

        [Description("Carbonised")]
        Carbonised = 3,

        [Description("Mohair")]
        Mohair = 4,

        [Description("Noils")]
        Noils = 5,

        [Description("Slipe")]
        Slipe = 6
    }
}
