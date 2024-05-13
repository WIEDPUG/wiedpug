using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WoolPreparationCategory
    {
        [Description("B: Bulk Class")]
        B,

        [Description("D: PTC (Pre-Sale Test Certificate Other Grower Lot)")]
        D,

        [Description("F: Premium Test")]
        F,

        [Description("I: Subjectively Appraised Interlot")]
        I,

        [Description("P: PTC (Pre-sale Test Certificate - Classed Grower Lot)")]
        P,

        [Description("Q: Bulk Class Quality Managed")]
        Q
    }
}
