using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [RemoveUnderscoreFromEnumItem]
    [Description("A code to indicate the different types of errors.")]
    public enum WarningCode
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
        DRVnn
    }
}
