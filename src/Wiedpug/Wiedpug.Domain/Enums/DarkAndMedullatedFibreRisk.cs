using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DarkAndMedullatedFibreRisk
    {
        [Description("ErrorInProcessing: Code: E. Error in Processing")]
        ErrorInProcessing,

        [Description("NotApplicable. Code: N. Not Applicable")]
        NotApplicable,

        [Description("NotDeclared: Code: D. Not Declared")]
        NotDeclared,

        [Description("RiskLevel1: Code: 1. Risk Level 1 (lowest)")]
        RiskLevel1,

        [Description("RiskLevel2: Code: 2. Risk Level 2")]
        RiskLevel2,

        [Description("RiskLevel3: Code: 3. Risk Level 3")]
        RiskLevel3,

        [Description("RiskLevel4: Code: 4. Risk Level 4")]
        RiskLevel4,

        [Description("RiskLevel5: Code: 5. Risk Level 5")]
        RiskLevel5,

        [Description("RiskLevel6: Code: 6. Risk Level 6")]
        RiskLevel6
    }
}
