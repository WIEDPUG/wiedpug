using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("This is Centres for Italy. " +
        "A centre is a town where any activity connected with the wool industry takes place. " +
        "The codes used in transmissions are those defined in the Australian Wool Selling Regulation.")]
    public enum CentreCodeItaly
    {

        [Description("ZI: Rome - Italy")]
        ZI,
        [Description("ZJ: Biella - Italy")]
        ZJ,
        [Description("ZK: Grisignano - Italy")]
        ZK
    }
}
