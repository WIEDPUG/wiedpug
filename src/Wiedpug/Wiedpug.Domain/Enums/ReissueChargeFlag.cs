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
    public enum ReissueChargeFlag
    {
        [Description("Original certificate charge")]
        OriginalCertificateCharge = 0,

        [Description("Re-issued no charge")]
        ReissuedNoCharge = 1,

        [Description("Re-issued with additional Charge")]
        ReissuedWithAdditionalCharge = 2,

        [Description("Re-issued with replacement charge (credit issued against original certificate)")]
        ReissuedWithReplacementCharge = 3
    }
}
