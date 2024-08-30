using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [Description("This field provides options to produce certificates for combinations, omls and/or associated sublots")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PrintFlag
    {
        [Description("P: Normal RPP/TCR request to pdf Certificate")]
        Normal,

        [Description("A: Pdf Combination/OML Certificate and associated sub-lots")]
        A,

        [Description("S: Pdf associated sub-lots excluding the Combination/OML Certificate")]
        S,

        [Description("C: Pdf Combination Certificate in Chinese and English")]
        C,

        [Description("E: Pdf Combination Certificate in Chinese and English & associated sublots in English)")]
        E,

        [Description("M: Pdf Combination Certificate in English & Mulesing Status report")]
        M,

        [Description("N: Pdf Mulesing Status report only")]
        N
    }
}
