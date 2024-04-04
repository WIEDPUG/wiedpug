<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [Description("Source of the lot presented for sale.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
>>>>>>> 376a2a5 (add TC classess)
