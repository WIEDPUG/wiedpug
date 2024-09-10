using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Enums
{
    [Description("Instruction to the test house on the type of change requested for the new Certificate Reissue.")]
    [RemoveUnderscoreFromEnumItem]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ReissueType
    {
        [Description("01: Wool Preparation Category (WPC) Change")]
        _01,

        [Description("02: Mulesing Status (MS) Change")]
        _02,

        [Description("03: Sale/Lot Change")]
        _03,

        [Description("04: WPC and MS Change")]
        _04,

        [Description("05: WPC and Sale/Lot Change")]
        _05,

        [Description("06: MS and Sale/Lot Change")]
        _06,

        [Description("07: WPC, MS and Sale/Lot Change")]
        _07
    }
}
