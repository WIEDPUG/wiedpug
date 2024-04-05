using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Wiedpug.Domain.Enums
{
    [Description("Source of the lot presented for sale.")]
    public enum SourceCode
    {
        [Description("1: Grower")]
        Grower = 1,

        [Description("2: Dealer")]
        Dealer = 2,

        [Description("3: BulkClass")]
        BulkClass = 3,
    }
}