using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("Source of the lot presented for sale.")]
    public enum SourceCode
    {
        [Description("Grower: Code: 1. Grower")]
        Grower = 1,

        [Description("Dealer: Code: 2. Dealer")]
        Dealer = 2,

        [Description("BulkClass: Code: 3. BulkClass")]
        BulkClass = 3,
    }
}