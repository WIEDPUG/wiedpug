using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [Description("Country Code using ISO 3166-1 standard")]
    public enum CountryCode
    {
        [Description("Australia: AU")]
        AU,

        [Description("New Zealand: NZ")]
        NZ,

        [Description("France: FR")]
        FR,

        [Description("South Africa: ZA")]
        ZA
    }
}
