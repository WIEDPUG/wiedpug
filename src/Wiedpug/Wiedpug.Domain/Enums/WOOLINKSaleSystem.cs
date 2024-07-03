using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WoolinkSaleSystem
    {

        [Description("A: Auction")]
        A,
        [Description("H: Holding")]
        H,
        [Description("O: Offer board")]
        O,
        [Description("W: Wool International")]
        W,
        [Description("S: Spot Sale")]
        S,
        [Description("T: Tender")]
        T,
        [Description("E:Electronic Auction")]
        E
    }
}
