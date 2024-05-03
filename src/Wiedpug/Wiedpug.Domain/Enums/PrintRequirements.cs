using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PrintRequirements
    {
        [Description("OriginalCertificateCharge: Code: 0. Yield and Laserscan are (to be) shown on the certificate")]
        OriginalCertificateCharge = 0,

        [Description("ReissuedNoCharge: Code: 1. Two certificates are (to be) issued, one with yield and one with Laserscan")]
        ReissuedNoCharge = 1,

        [Description("ReissuedWithAdditionalCharge: Code: 2. Yield only is (to be) shown, the actual yields being those indicated by the values in the Yield Type fields")]
        ReissuedWithAdditionalCharge = 2,

        [Description("ReissuedWithReplacementCharge: Code: 3. Laserscan only is (to be) shown)")]
        ReissuedWithReplacementCharge = 3
    }
}
