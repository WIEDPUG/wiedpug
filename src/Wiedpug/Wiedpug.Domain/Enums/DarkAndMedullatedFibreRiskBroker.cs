using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DarkAndMedullatedFibreRiskBroker
    {
        [Description("Risklevel1: Code: 1. Risk Level 1 (lowest)")]
        Risklevel1,

        [Description("Risklevel2: Code: 2. Risk Level 2")]
        Risklevel2,

        [Description("Risklevel3: Code: 3. Risk Level 3")]
        Risklevel3,

        [Description("Risklevel4: Code: 4. Risk Level 4")]
        Risklevel4,

        [Description("Risklevel5: Code: 5. Risk Level 5")]
        Risklevel5,

        [Description("Risklevel6: Code: 6. Risk Level 6")]
        Risklevel6
    }
}
