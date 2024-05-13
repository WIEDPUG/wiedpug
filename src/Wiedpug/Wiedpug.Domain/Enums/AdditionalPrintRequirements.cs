using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum AdditionalPrintRequirements
    {
        [Description("0: No additional print requirements")]
        NoAdditionalRequirements = 0,

        [Description("1: Print VM Breakdown only")]
        VMBreakdown = 1,

        [Description("2: Print VM Breakdown and Curvature")]
        VMBreakdownAndCurvature = 2,

        [Description("3: Print VM Breakdown and Comfort Factor")]
        VMBreakdownAndConfortFactor = 3,

        [Description("4: Print VM Breakdown, Curvature and Comfort Factor")]
        VMBreakdownAndCurvatureAndComfortFactor = 4,

        [Description("5: Print Curvature only")]
        Curvature = 5,

        [Description("6: Print Comfort Factor Only")]
        ComfortFactor = 6,

        [Description("7: Print Curvature and Comfort Factor")]
        CurvatureAndComfortFactor = 7

    }
}
