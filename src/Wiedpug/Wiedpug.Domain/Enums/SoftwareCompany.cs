using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum SoftwareCompany
    {
        [Description("1: Talman")]
        Talman = 1,

        [Description("2: Symbotic")]
        Symbotic = 2,

        [Description("3: Jumbuck/Datacon")]
        JumbuckOrDatacon = 3,

        [Description("4: Jemalong")]
        Jemalong = 4,

        [Description("5: NA - no value")]
        NA = 5,

        [Description("6: Modiano")]
        Modiano = 6,

        [Description("7: AWH")]
        AWH = 7,

        [Description("8: AWTA")]
        AWTA = 8
    }
}
