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
        [Description("Auction: Code: A. Auction (open cry)")]
        Auction,

        [Description("Tender: Code: T. Tender")]
        Tender,

        [Description("Offer: Code: O. Offer")]
        Offer,

        [Description("Availability: Code: AV. Availability")]
        Availability,

        [Description("ElectronicSale: Code: E. Electronic Sale")]
        ElectronicSale
    }
}
