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
    [Description("This is Centres for China. " +
        "A centre is a town where any activity connected with the wool industry takes place. " +
        "The codes used in transmissions are those defined in the Australian Wool Selling Regulation.")]
    public enum CentreCodeChina
    {

        [Description("NJ: Nanjing - China")]
        NA,
        [Description("SH: Shanghai - China")]
        SH,
        [Description("QD: Qingdao - China")]
        QI,
        [Description("ZJ: Zhangjiagang - China")]
        ZH
    }
}
