using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Enums
{
     [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ReissueType
    {
        [Description("01: Wool Preparation Category (WPC) Change")]
        01,

        [Description("02: Mulesing Status (MS) Change")]
        02,

        [Description("03: Sale/Lot Change")]
        03,

        [Description("04: WPC and MS Change")]
        04,

        [Description("05: WPC and Sale/Lot Change")]
        05,

        [Description("06: MS and Sale/Lot Change")]
        06,

        [Description("07: WPC, MS and Sale/Lot Change")]
        07
    }
}
