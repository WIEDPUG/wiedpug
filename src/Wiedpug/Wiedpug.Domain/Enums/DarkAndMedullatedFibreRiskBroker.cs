using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum DarkAndMedullatedFibreRiskBroker
    {
        [Description("1: Risk Level 1 (lowest)")]
        Risklevel1 = 1,

        [Description("2: Risk Level 2")]
        Risklevel2 = 2,

        [Description("3: Risk Level 3")]
        Risklevel3 = 3,

        [Description("4: Risk Level 4")]
        Risklevel4 = 4,

        [Description("5: Risk Level 5")]
        Risklevel5 = 5,

        [Description("6: Risk Level 6")]
        Risklevel6 = 6
    }
}
