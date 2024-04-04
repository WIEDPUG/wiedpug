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
    public enum SourceCode
    {
        [Description("1: Grower")]
        Grower = 1,

        [Description("2: Dealer")]
        Dealer = 2,

        [Description("3: BulkClass")]
        BulkClass = 3,
    }
}
