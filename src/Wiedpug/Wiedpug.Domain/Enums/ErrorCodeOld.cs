using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [RemoveUnderscoreFromEnumItem]
    [Description("A code to indicate the different types of errors.")]
    public enum ErrorCodeOld
    {
        [Description("11: Weight Note suffix is not numeric or has been omitted.")]
        _11,

        [Description("12: Number of bales is invalid or has been omitted.")]
        _12,

        [Description("13: Sale identification has been omitted.")]
        _13,

        [Description("18: Invalid Gross weight.")]
        _18,

        [Description("19: Invalid Tare weight.")]
        _19,

        [Description("20: Invalid Centre/Client code on pre-sale test request.")]
        _20,

        [Description("24: Incorrect PCTR Hash total.")]
        _24,

        [Description("DRVnn: Dark and Medullated Fibre Risk error where nn is the field number in error.")]
        DRVnn,

        [Description("FTTPE: Unknown error detected by FTTP - All data rejected.")]
        FTTPE,

        [Description("INVFL: Invalid file layout - All data rejected.")]
        INVFL,

        [Description("INVER: Invalid date format - All data rejected.")]
        INVER,

        [Description("INVFT: Invalid file type - All data rejected.")]
        INVFT,

        [Description("NETIE: Internal network error - Contact Network Administration.")]
        NETIE,

        [Description("ATYF: Adding to your data file, please try again later.")]
        ATYF,

        [Description("BLPSW: Blank password received. All data rejected.")]
        BLPSW,

        [Description("DOXCT: Document originator does not match current transmitter.")]
        DOXCT,

        [Description("INV00: Invalid record TransmissionHeader received. All data rejected.")]
        INV00,

        [Description("INV09: Invalid/missing FinalReceiverList record. All data rejected.")]
        INV09,

        [Description("INV53: Invalid request for data.")]
        INV53,

        [Description("INVAC: Invalid sale aann/nn dd/mm/yy ooooo. All data rejected.")]
        INVAC,

        [Description("INVCR: Current receiver not awtm. All data rejected.")]
        INVCR,

        [Description("INVCT: Invalid current transmitter code. All data rejected.")]
        INVCT,

        [Description("INVDO: Invalid document originator code aaaaa. Data accepted.")]
        INVDO,

        [Description("INVFR: Invalid final receiver aaaaa. This data rejected.")]
        INVFR,

        [Description("INVRT: Invalid record type at line NNNNNN. All data rejected.")]
        INVRT,

        [Description("INVSO: Warning! Invalid selling org AAAAA using doc orig AAAAA.")]
        INVSO,


        [Description("INVP: Invalid password. All data rejected.")]
        INVP,

        [Description("INVSR: Invalid sum count. Type nn should be nnnnn. Data rejected.")]
        INVSR,

        [Description("INVEX: Invalid excluded record.")]
        INVEX,


        [Description("MAXS: Maximum size of request reached. Request smaller file.")]
        MAXS,


        [Description("MISS00: Missing type TransmissionHeader record. All data rejected.")]
        MISS00,


        [Description("MIS10: Missing type 10 record. All data rejected.")]
        MIS10,


        [Description("N80CH: Data received not in 80-character block. All data rejected.")]
        N80CH,


        [Description("NASCI: Non-ASCII characters received. All data rejected.")]
        NASCI,

        [Description("NDTS: No data to send.")]
        NDTS,

        [Description("NETUA: Network unavailable, please try again later.")]
        NETUA,

        [Description("NOTBR: Should be broadcast data. All data rejected.")]
        NOTBR,

        [Description("NSBCT: Current transmitter not an AWTM subscriber. Data rejected.")]
        NSBCT,

        [Description("NSBFR: Final receiver aaaaa not an AWTM-EDI subscriber. Data rejected.")]
        NSBFR,

    }
}
