using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum SaleOutcome
    {
        [Description("0: Sold")]
        Sold = 0,

        [Description("1: Passed In")]
        PassedIn = 1,

        [Description("2: Lot withdrawn from sale")]
        LotWithdrawnFromSale = 2,

        [Description("3: No bid")]
        NoBid = 3,

        [Description("4: Transfer")]
        Transfer = 4,

        [Description("6: Bid or Offer Price")]
        BidOrOfferPrice = 6,

        [Description("7: Withdrawn – Sold Prior")]
        WithdrawnSoldPrior = 7
    }
}
