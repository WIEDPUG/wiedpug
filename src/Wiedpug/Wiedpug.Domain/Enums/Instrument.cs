using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
