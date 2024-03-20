using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{    
    public enum RequestType
    {
        [Description("1: Private Data Request")]
        PrivateDataRequest = 1,

        [Description("2: Status Request")]
        StatusRequest = 2,

        [Description("3: Data Request")]
        DataRequest = 3,

        [Description("4: Broadcast Data Request")]
        BroadcastDataRequest = 4
    }
}
