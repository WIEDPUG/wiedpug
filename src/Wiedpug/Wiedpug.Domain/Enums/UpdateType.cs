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
        [Description("Add: Code: A. The entry is to be added")]
        Add,

        [Description("Change: Code: C. The entry is to be changed")]
        Change,

        [Description("Delete: Code: D. The entry is to be deleted")]
        Delete
    }
}
