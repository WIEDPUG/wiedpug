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
        [Description("InformationOnly: Code: R. Report, results for this test are supplied for information only")]
        InformationOnly,

        [Description("ResultsCertified: Code: C. Certificate results for this test are certified")]
        ResultsCertified,

        [Description("Untested: Code: U. This lot is untested and there are no certificate results")]
        Untested
    }
}
