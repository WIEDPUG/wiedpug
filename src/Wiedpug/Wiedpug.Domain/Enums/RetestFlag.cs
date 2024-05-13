using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    public enum RetestFlag
    {
        [Description("0: Normal Test")]
        NormalTest = 0,

        [Description("1: Retest")]
        Retest = 1,

        [Description("2: Check Test")]
        CheckTest = 2
    }
}
