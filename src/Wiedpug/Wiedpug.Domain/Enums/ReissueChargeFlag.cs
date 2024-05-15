using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum ReissueChargeFlag
    {
        [Description("0: Original certificate charge")]
        OriginalCertificateCharge = 0,

        [Description("1: Re-issued no charge")]
        ReissuedNoCharge = 1,

        [Description("2: Re-issued with additional Charge")]
        ReissuedWithAdditionalCharge = 2,

        [Description("3: Re-issued with replacement charge (credit issued against original certificate)")]
        ReissuedWithReplacementCharge = 3
    }
}
