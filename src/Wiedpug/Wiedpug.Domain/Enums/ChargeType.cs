using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ChargeType
    {   
        PenaltyInterest,

        MiscellaneousAdjustments
    }
}
