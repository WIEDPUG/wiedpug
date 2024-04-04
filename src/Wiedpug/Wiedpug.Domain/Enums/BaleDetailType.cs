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
    public enum BaleDetailType
    {
        [Description("Renumbers: Bale Details - Renumbers")]
        Renumbers,

        [Description("GreasyOrProcessed: Bale Details - GreasyOrProcessed")]
        GreasyOrProcessed,

        [Description("Tripacks: Bale Details - Tripacks")]
        Tripacks,
    }
}
