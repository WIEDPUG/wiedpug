using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum CertificateDeliveryIndicator
    {
        [Description("0: Deliver to Broker/Buyer Address")]
        ToBrokerOrBuyerAddress = 0,

        [Description("1: Deliver to Clearing House")]
        ToClearingHouse = 1
    }
}
