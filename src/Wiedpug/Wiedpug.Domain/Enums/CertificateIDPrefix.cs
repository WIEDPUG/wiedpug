using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CertificateIDPrefix
    {
        [Description("SydneyLaboratory: Code: 2. Sydney Laboratory")]
        SydneyLaboratory,

        [Description("MelbourneLaboratory: Code: 3. Melbourne Laboratory")]
        MelbourneLaboratory,

        [Description("FremantleLaboratory: Code: 6. Fremantle Laboratory")]
        FremantleLaboratory
    }
}
