using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum CertificateIDPrefix
    {
        [Description("2: Sydney Laboratory")]
        SydneyLaboratory = 2,

        [Description("3: Melbourne Laboratory")]
        MelbourneLaboratory = 3,

        [Description("6: Fremantle Laboratory")]
        FremantleLaboratory = 6
    }
}
