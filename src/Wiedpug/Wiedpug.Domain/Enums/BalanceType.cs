using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BalanceType
    {
        [Description("Current: Balance - Current")]
        Current,

        [Description("30: Balance - 30")]
        Thirty,

        [Description("60: Balance - 60")]
        Sixty,

        [Description("90: Balance - 90")]
        Ninety,

        [Description("90Plus: Balance - 90+")]
        NinetyPlus,
    }
}
