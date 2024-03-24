using System.ComponentModel;

namespace Wiedpug.Domain.Enums
{
    public enum RequestType
    {
        [Description("1: Private Data Request")]
        PrivateDataRequest = 1,

        [Description("2: Status Request")]
        StatusRequest = 2,

        [Description("3: Data Request")]
        DataRequest = 3,

        [Description("4: Broadcast Data Request")]
        BroadcastDataRequest = 4
    }
}
