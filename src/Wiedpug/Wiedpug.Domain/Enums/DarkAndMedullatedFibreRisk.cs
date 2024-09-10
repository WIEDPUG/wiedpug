using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{
    [Description("The following codes are applicable to lots sampled on or after 1st July, 2004. Spaces will be returned for lots sampled before this date where data is not provided.")]
    [RemoveUnderscoreFromEnumItem]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DarkAndMedullatedFibreRisk
    {
        [Description("E: Error in Processing")]
        E,

        [Description("N: Not Applicable")]
        N,

        [Description("D: Not Declared")]
        D,

        [Description("1: Risk Level 1 (lowest)")]
        _1,

        [Description("2: Risk Level 2")]
        _2,

        [Description("3: Risk Level 3")]
        _3,

        [Description("4: Risk Level 4")]
        _4,

        [Description("5: Risk Level 5")]
        _5,

        [Description("6: Risk Level 6")]
        _6
    }
}
