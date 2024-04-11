﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [Description("")]
    public enum TransmissionTypeForAuctionCatalogue
    {
        [Description("2: Auction Catalogues")]
        AuctionCatalogues = 2,

        [Description("3: Private Catalogues")]
        PrivateCatalogues = 3,

        [Description("5: Auction Catalogue Updates")]
        AuctionCatalogueUpdates = 5,
    }
}