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
    /// <summary>
    /// 
    /// 
    /// 
    /// </summary>    
    [Description("This is Centres for Overseas. " +
        "A centre is a town where any activity connected with the wool industry takes place. " +
        "The codes used in transmissions are those defined in the Australian Wool Selling Regulation.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CentreOverseas
    {

        //Overseas
        [Description("ZA: Overseas - Australia")]
        ZA,
        [Description("ZB: Overseas - Belgium")]
        ZB,
        [Description("ZC: Overseas - Christchurch - New Zealand")]
        ZC,
        [Description("ZD: Overseas - Dunedin - New Zealand")]
        ZD,
        [Description("ZE: Overseas - England")]
        ZE,
        [Description("ZF: Overseas - France")]
        ZF,
        [Description("ZG: Overseas - Germany")]
        ZG,
        [Description("ZH: Overseas - Blumenthal - Germany")]
        ZH,
        [Description("ZI: Overseas - Italy")]
        ZI,
        [Description("ZJ: Overseas - Biella - Italy")]
        ZJ,
        [Description("ZK: Overseas - Grisignano - Italy")]
        ZK,
        [Description("ZL: Overseas - Mosgiel - New Zealand")]
        ZL,
        [Description("ZM: Overseas - Nanjing - China")]
        ZM,
        [Description("ZN: Overseas - Netherlands")]
        ZN,
        [Description("ZO: Overseas - Keelung - Taiwan")]
        ZO,
        [Description("ZP: Overseas - Shanghai - China")]
        ZP,
        [Description("ZQ: Overseas - Qingdao - China")]
        ZQ,
        [Description("ZR: Overseas - Zhangjiagang - China")]
        ZR,
        [Description("ZS: Overseas - South Africa")]
        ZS,
        [Description("ZT: Overseas - Timaru - New Zealand")]
        ZT,
        [Description("ZU: Overseas - USA")]
        ZU,
        [Description("ZV: Overseas - Invercargill - New Zealand")]
        ZV,
        [Description("ZW: Overseas - Wellington - New Zealand")]
        ZW,
        [Description("ZX: Overseas - Napier - New Zealand")]
        ZX,
        [Description("ZY: Overseas - Ashburton - New Zealand")]
        ZY,
        [Description("ZZ: Overseas - New Zealand")]
        ZZ

    }
}
