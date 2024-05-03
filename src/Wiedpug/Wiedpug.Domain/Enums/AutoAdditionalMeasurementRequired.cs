using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AutoAdditionalMeasurementRequired
    {
        [Description("NoAutomaticCombinationsRequired: Code: N. Automatic combinations not required")]
        NoAutomaticCombinationsRequired,

        [Description("AutomaticLengthAndStrengthCombinationRequired: Code: L. Automatic Length & Strength Combination required")]
        AutomaticLengthAndStrengthCombinationRequired,

        [Description("AutomaticColourCombinationRequired: Code: C. Automatic Colour Combination is required")]
        AutomaticColourCombinationRequired,

        [Description("LengthStrengthAndColourCombinations: Code: B. Both Length & Strength and Colour combinations required")]
        LengthStrengthAndColourCombinations
    }
}
