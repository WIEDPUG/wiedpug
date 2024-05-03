using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeliveryBasis
    {
        [Description("DeliveryNominatedDestination: Code: D. Delivery Nominated Destination")]
        DeliveryNominatedDestination,

        [Description("LoadedOnTransport: Code: L. Loaded on Transport")]
        LoadedOnTransport
    }
}
