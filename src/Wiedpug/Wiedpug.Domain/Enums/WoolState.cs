using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [RemoveUnderscoreFromEnumItem]
    [Description("The state of the wool itemised in the invoice.")]
    public enum WoolState
    {
        [Description("1. Greasy")]
        _1,

        [Description("2. Dead")]
        _2,

        [Description("3. Slipe")]
        _3,

        [Description("4. Scoured")]
        _4,

        [Description("5. Carbonised")]
        _5,

        [Description("6. Wool tops")]
        _6,

        [Description("7. Wool noils")]
        _7,

        [Description("8. Carded sliver")]
        _8,

        [Description("9. Other processed wool")]
        _9,

        [Description("A. Alpaca")]
        A,

        [Description("C. Cashmere")]
        C,

        [Description("M. Mohair")]
        M
    }
}
