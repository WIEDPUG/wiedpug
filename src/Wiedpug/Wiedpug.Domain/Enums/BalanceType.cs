using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BalanceType
    {
        [Description("Current: Balance - Current")]
        Current,

        [Description("Thirty: Balance - 30")]
        Thirty,

        [Description("Sixty: Balance - 60")]
        Sixty,

        [Description("Ninety: Balance - 90")]
        Ninety,

        [Description("NinetyPlus: Balance - 90+")]
        NinetyPlus,
    }
}
