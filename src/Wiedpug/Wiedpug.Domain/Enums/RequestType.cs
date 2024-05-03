using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RequestType
    {
        [Description("PrivateDataRequest: Code: 1. Private Data Request")]
        PrivateDataRequest = 1,

        [Description("StatusRequest: Code: 2. Status Request")]
        StatusRequest = 2,

        [Description("DataRequest: Code: 3. Data Re-Request")]
        DataRequest = 3,

        [Description("BroadcastDataRequest: Code: 4. Broadcast Data Request")]
        BroadcastDataRequest = 4
    }
}
