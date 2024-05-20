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
    public enum SaleType
    {
        [Description("A: Auction (open cry)")]
        A,

        [Description("T: Tender")]
        T,

        [Description("O: Offer")]
        O,

        [Description("AV: Availability")]
        AV,

        [Description("E: Electronic Sale")]
        E
    }
}
