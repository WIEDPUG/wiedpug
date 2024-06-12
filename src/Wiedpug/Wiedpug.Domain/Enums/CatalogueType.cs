using System.ComponentModel;

namespace Wiedpug.Domain.Enums
{
    public enum CatalogueType
    {
        [Description("1: Auction Catalogues")]
        AuctionCatalogues = 1,

        [Description("2: Private Catalogues")]
        PrivateCatalogues = 2
    }
}
