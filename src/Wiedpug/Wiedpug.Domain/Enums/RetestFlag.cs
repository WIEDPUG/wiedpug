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
    public enum RetestFlag
    {
        [Description("Normal Test")]
        NormalTest = 0,
        [Description("Retest")]
        Retest = 1,
        [Description("Check Test")]
        CheckTest = 2
    }
}
