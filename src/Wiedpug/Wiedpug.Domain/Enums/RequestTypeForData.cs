using System.ComponentModel;

namespace Wiedpug.Domain.Enums
{
    public enum RequestTypeForData
    {
        [Description("1: Private Data Request")] //For PC - Returns AC
        PrivateDataRequest = 1,

        //I removed "2: Status Request" because this type of request will be in a separate API endpoint.
        //This type of request returns a Status Reply document type, while other requests types will return the same Auction Catalogue document type.

        //[Description("2: Status Request")] //For PC - Returns SR
        //StatusRequest = 2,

        [Description("3: Data Re-Request")] //For AC, PC, ACU - Returns AC
        DataRequest = 3,

        [Description("4: Broadcast Data Request")] //For AC, PC, ACU - Returns AC
        BroadcastDataRequest = 4
    }
}
