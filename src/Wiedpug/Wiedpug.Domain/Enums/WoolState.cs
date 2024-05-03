using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Attributes;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]    
    [Description("The state of the wool itemised in the invoice.")]
    public enum WoolState
    {
        [Description("Greasy: Code: 1. Greasy")]
        Greasy,

        [Description("Dead: Code: 2. Dead")]
        Dead,

        [Description("Slipe: Code: 3. Slipe")]
        Slipe,

        [Description("Scoured: Code: 4. Scoured")]
        Scoured,

        [Description("Carbonised: Code: 5. Carbonised")]
        Carbonised,

        [Description("WoolTops: Code: 6. Wool tops")]
        WoolTops,

        [Description("WoolNoils: Code: 7. Wool noils")]
        WoolNoils,

        [Description("CardedSliver: Code: 8. Carded sliver")]
        CardedSliver,

        [Description("OtherProcessedWool: Code: 9. Other processed wool")]
        OtherProcessedWool,

        [Description("Alpaca: Code: A. Alpaca")]
        Alpaca,

        [Description("Cashmere: Code: C. Cashmere")]
        Cashmere,

        [Description("Mohair: Code: M. Mohair")]
        Mohair
    }
}
