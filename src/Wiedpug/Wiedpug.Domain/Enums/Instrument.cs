using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Instrument
    {
        [Description("LaserScan: Code: 1. Laserscan")]   
        LaserScan = 1,

        [Description("OFDA: Code: 2. OFDA")]
        OFDA = 2
    }
}
