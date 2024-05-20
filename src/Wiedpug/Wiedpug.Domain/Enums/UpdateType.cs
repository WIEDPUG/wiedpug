using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [Description("A flag to indicate what type of change has been made to an item.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UpdateType
    {
        [Description("A: The entry is to be added")]
        A,

        [Description("C: The entry is to be changed")]
        C,

        [Description("D: The entry is to be deleted")]
        D
    }
}
