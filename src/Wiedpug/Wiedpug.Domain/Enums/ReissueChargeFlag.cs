using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ReissueChargeFlag
    {
        [Description("OriginalCertificateCharge: Code: 0. Original certificate charge")]
        OriginalCertificateCharge = 0,

        [Description("ReissuedNoCharge: Code: 1. Re-issued no charge")]
        ReissuedNoCharge = 1,

        [Description("ReissuedWithAdditionalCharge: Code: 2. Re-issued with additional Charge")]
        ReissuedWithAdditionalCharge = 2,

        [Description("ReissuedWithReplacementCharge: Code: 3. Re-issued with replacement charge (credit issued against original certificate)")]
        ReissuedWithReplacementCharge = 3
    }
}
