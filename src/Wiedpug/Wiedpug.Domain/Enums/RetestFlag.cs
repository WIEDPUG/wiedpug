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
        [Description("NormalTest: Code: 0. Normal Test")]
        NormalTest = 0,

        [Description("Retest: Code: 1. Retest")]
        Retest = 1,

        [Description("CheckTest: Code: 2. Check Test")]
        CheckTest = 2
    }
}
