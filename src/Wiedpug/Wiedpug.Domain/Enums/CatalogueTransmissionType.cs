using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [Description(" Used to define the types of Catalogue. Only required for requesting Catalouge. Not Applicable for other documents.")]
    public enum CatalogueTransmissionType
    {
        [Description("2: Auction Catalogues")]
        AuctionCatalogues = 2,

        [Description("3: Private Catalogues")]
        PrivateCatalogues = 3,

        [Description("5: Auction Catalogue Updates")]
        AuctionCatalogueUpdates = 5,
    }
}
