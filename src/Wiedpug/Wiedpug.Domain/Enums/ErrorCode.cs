using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("A code to indicate the different types of errors.")]
    public enum ErrorCode
    {
        [Description("DOXCT: Document originator does not match current transmitter.")]
        DOXCT,

        [Description("INVTC: Invalid transfer config. All data rejected.")]
        INVTC,

        [Description("INVFR: Invalid/missing FinalReceiverList record. All data rejected.")]
        INVFR,

        [Description("INVAC: Invalid sale aann/nn dd/mm/yy ooooo. All data rejected.")]
        INVAC,

        [Description("INVCR: Current receiver not awtm. All data rejected.")]
        INVCR,

        [Description("INVDO: Invalid document originator code aaaaa. Data accepted.")]
        INVDO,

        [Description("INVSO: Warning! Invalid selling org AAAAA using doc orig AAAAA.")]
        INVSO,

        [Description("INVEX: Invalid excluded record.")]
        INVEX,

    }
}
