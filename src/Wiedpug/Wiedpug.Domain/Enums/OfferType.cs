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
    public enum OfferType
    {
        [Description("P: Previous/Passed-In Price")]
        P,

        [Description("N: Negotiable Price")]
        N,

        [Description("R: Reserve Price")]
        R
    }
}
