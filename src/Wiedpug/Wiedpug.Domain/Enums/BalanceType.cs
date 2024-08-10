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
        _30,

        [Description("60: Balance - 60")]
        _60,

        [Description("Closing: Balance - 90")]
        _90,

        [Description("Closing: Balance - 90+")]
        _90Plus,
    }
}
