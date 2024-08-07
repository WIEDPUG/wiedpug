using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum RequestTypeForData
    {
        [Description("1: Private Data Request")] //For PC - Returns AC
        PrivateDataRequest = 1,

        [Description("3: Data Re-Request")] //For AC, PC, ACU - Returns AC
        DataRequest = 3,

        [Description("4: Broadcast Data Request")] //For AC, PC, ACU - Returns AC
        BroadcastDataRequest = 4
    }
}
