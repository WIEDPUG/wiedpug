﻿using System;
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
        [Description("PreviousOrPassedInPrice: Code: P. Previous/Passed-In Price")]
        PreviousOrPassedInPrice,

        [Description("NegotiablePrice: Code: N. Negotiable Price")]
        NegotiablePrice,

        [Description("ReservePrice: Code: R. Reserve Price")]
        ReservePrice
    }
}
