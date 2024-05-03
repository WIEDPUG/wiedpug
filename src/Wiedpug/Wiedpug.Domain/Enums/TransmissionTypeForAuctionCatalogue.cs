using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [Description("")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TransmissionTypeForAuctionCatalogue
    {
        [Description("AuctionCatalogues: Code: 2. Auction Catalogues")]
        AuctionCatalogues = 2,

        [Description("PrivateCatalogues: Code: 3. Private Catalogues")]
        PrivateCatalogues = 3,

        [Description("AuctionCatalogueUpdates: Code: 5. Auction Catalogue Updates")]
        AuctionCatalogueUpdates = 5,
    }
}
