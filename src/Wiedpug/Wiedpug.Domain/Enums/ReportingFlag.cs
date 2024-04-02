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
        [Description("R: Report, results for this test are supplied for information only")]
        R,
        [Description("C: Certificate results for this test are certified")]
        C,
        [Description("U: This lot is untested and there are no certificate results")]
        U
    }
}
