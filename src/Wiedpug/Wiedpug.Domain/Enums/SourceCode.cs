using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [Description("Source of the lot presented for sale.")]
    public enum SourceCode
    {
        [Description("1: Grower")]
        PrivateDataRequest = 1,

        [Description("2: Dealer")]
        StatusRequest = 2,

        [Description("3: Bulk Class")]
        DataRequest = 3
    }
}
