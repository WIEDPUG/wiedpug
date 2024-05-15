using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RequestType
    {
        [Description("1: Private Data Request")]
        PrivateDataRequest = 1,

        [Description("2: Status Request")]
        StatusRequest = 2,

        [Description("3: Data Re-Request")]
        DataRequest = 3,

        [Description("4: Broadcast Data Request")]
        BroadcastDataRequest = 4
    }
}
