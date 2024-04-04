using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Laboratory
    {
        [Description("Australian Wool Testing Authority")]
        AustralianWoolTestingAuthority = 1,

        [Description("N.Z. Wool Testing Authority")]
        NZWoolTestingAuthority = 2,

        [Description("N.Z. Wool Testing Service")]
        NZWoolTestingService = 3,

        [Description("South African Wool Testing Authority")]
        SouthAfricanWoolTestingAuthority = 4,
    }
}
