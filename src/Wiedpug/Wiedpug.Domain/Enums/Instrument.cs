using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum Instrument
    {
        [Description("1: Laserscan")]
        LaserScan = 1,
        [Description("2: OFDA")]
        OFDA = 2
    }
}
