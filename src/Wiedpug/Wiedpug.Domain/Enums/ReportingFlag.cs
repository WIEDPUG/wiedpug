using System.ComponentModel;
using System.Text.Json.Serialization;

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
