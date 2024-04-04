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
    public enum ReportingFlag
    {
        [Description("Report, results for this test are supplied for information only")]
        R,

        [Description("Certificate results for this test are certified")]
        C,

        [Description("This lot is untested and there are no certificate results")]
        U
    }
}
