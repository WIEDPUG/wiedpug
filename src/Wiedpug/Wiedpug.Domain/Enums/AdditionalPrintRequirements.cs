using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AdditionalPrintRequirements
    {
        [Description("NoAdditionalRequirements: Code: 0. No additional print requirements")]
        NoAdditionalRequirements,

        [Description("VMBreakdown: Code: 1. Print VM Breakdown only")]
        VMBreakdown,

        [Description("VMBreakdownAndCurvature: Code: 2. Print VM Breakdown and Curvature")]
        VMBreakdownAndCurvature,

        [Description("VMBreakdownAndConfortFactor: Code: 3. Print VM Breakdown and Comfort Factor")]
        VMBreakdownAndConfortFactor,

        [Description("VMBreakdownAndCurvatureAndComfortFactor: Code: 4. Print VM Breakdown, Curvature and Comfort Factor")]
        VMBreakdownAndCurvatureAndComfortFactor,

        [Description("Curvature: Code: 5. Print Curvature only")]
        Curvature,

        [Description("ComfortFactor: Code: 6. Print Comfort Factor Only")]
        ComfortFactor,

        [Description("CurvatureAndComfortFactor: Code: 7. Print Curvature and Comfort Factor")]
        CurvatureAndComfortFactor

    }
}
