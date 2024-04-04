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
        [Description("Delivery Nominated Destination")]
        D,
        [Description("Loaded on Transport")]
        L
    }
}
