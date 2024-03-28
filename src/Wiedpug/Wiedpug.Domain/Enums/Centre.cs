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
    /// This is combined Centres for Australia, Overseas and New Zealand.
    /// A centre is a town where any activity connected with the wool industry takes place.
    /// The codes used in transmissions are those defined in the Australian Wool Selling Regulation.
    /// </summary>    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Centre
    {
        //Australia
        [Description("AU_A: Australia - ADELAIDE")]
        AU_A,
        [Description("AU_AD: Australia - Ardlethan")]
        AU_AD,
        [Description("AU_AR: Australia - Armidale (NSW)")]
        AU_AR,
        [Description("AU_AU: Australia - AUSTRALIA (AWEX internal only)")]
        AU_AU,
        [Description("AU_B: Australia - BRISBANE")]
        AU_B,
        [Description("AU_BA: Australia - Benalla")]
        AU_BA,
        [Description("AU_BK: Australia - Bourke")]
        AU_BK,
        [Description("AU_BL: Australia - Ballarat")]
        AU_BL,
        [Description("AU_BM: Australia - Barham")]
        AU_BM,
        [Description("AU_BO: Australia - Boorowa")]
        AU_BO,
        [Description("AU_BR: Australia - Bordertown")]
        AU_BR,
        [Description("AU_BT: Australia - Bathurst")]
        AU_BT,
        [Description("AU_C: Australia - Cooma")]
        AU_C,
        [Description("AU_CA: Australia - Casterton")]
        AU_CA,
        [Description("AU_CB: Australia - Coonabarabran")]
        AU_CB,
        [Description("AU_CC: Australia - Culcairn")]
        AU_CC,
        [Description("AU_CL: Australia - Coleraine")]
        AU_CL,
        [Description("AU_CN: Australia - Condoblin")]
        AU_CN,
        [Description("AU_CO: Australia - Cootamundra")]
        AU_CO,
        [Description("AU_CR: Australia - Corowa")]
        AU_CR,
        [Description("AU_CU: Australia - Cunnamulla")]
        AU_CU,
        [Description("AU_CW: Australia - Crookwell")]
        AU_CW,
        [Description("AU_D: Australia - Bendigo")]
        AU_D,
        [Description("AU_DE: Australia - Deniliquin")]
        AU_DE,
        [Description("AU_DO: Australia - Dubbo")]
        AU_DO,
        [Description("AU_DR: Australia - Canowindra")]
        AU_DR,
        [Description("AU_E: Australia - Echuca")]
        AU_E,
        [Description("AU_ER: Australia - Euroa")]
        AU_ER,
        [Description("AU_ES: Australia - Esperance")]
        AU_ES,
        [Description("AU_F: Australia - FREMANTLE")]
        AU_F,
        [Description("AU_G: Australia - GEELONG")]
        AU_G,
        [Description("AU_GF: Australia - Grenfell")]
        AU_GF,
        [Description("AU_GI: Australia - Glenn Innes")]
        AU_GI,
        [Description("AU_GN: Australia - Gunning")]
        AU_GN,
        [Description("AU_GR: Australia - Griffith")]
        AU_GR,
        [Description("AU_GU: Australia - Guyra")]
        AU_GU,
        [Description("AU_H: Australia - Hobart")]
        AU_H,
        [Description("AU_HA: Australia - Harden")]
        AU_HA,
        [Description("AU_HB: Australia - Holbrook")]
        AU_HB,
        [Description("AU_HM: Australia - Hamilton")]
        AU_HM,
        [Description("AU_HO: Australia - Horsham")]
        AU_HO,
        [Description("AU_HY: Australia - Hay")]
        AU_HY,
        [Description("AU_I: Australia - Narrabri")]
        AU_I,
        [Description("AU_J: Australia - Parkes")]
        AU_J,
        [Description("AU_JA: Australia - Jamestown")]
        AU_JA,
        [Description("AU_K: Australia - Warracknabeal")]
        AU_K,
        [Description("AU_KE: Australia - Kerang")]
        AU_KE,
        [Description("AU_KH: Australia - Keith")]
        AU_KH,
        [Description("AU_KI: Australia - Kangaroo Island")]
        AU_KI,
        [Description("AU_KN: Australia - Kingston")]
        AU_KN,
        [Description("AU_KT: Australia - Katanning")]
        AU_KT,
        [Description("AU_KW: Australia - Wagga Wagga")]
        AU_KW,
        [Description("AU_KY: Australia - Kyneton")]
        AU_KY,
        [Description("AU_L: Australia - LAUNCESTON")]
        AU_L,
        [Description("AU_LC: Australia - Lane Cove (AWEX internal only)")]
        AU_LC,
        [Description("AU_M: Australia - MELBOURNE")]
        AU_M,
        [Description("AU_MA: Australia - Mansfield")]
        AU_MA,
        [Description("AU_MB: Australia - Murray Bridge")]
        AU_MB,
        [Description("AU_MC: Australia - Macarthur")]
        AU_MC,
        [Description("AU_ME: Australia - Melton")]
        AU_ME,
        [Description("AU_MG: Australia - Mount Gambier")]
        AU_MG,
        [Description("AU_MI: Australia - Mildura")]
        AU_MI,
        [Description("AU_MO: Australia - Moree")]
        AU_MO,
        [Description("AU_MR: Australia - Maryborough")]
        AU_MR,
        [Description("AU_MU: Australia - Mudgee")]
        AU_MU,
        [Description("AU_N: Australia - NEWCASTLE")]
        AU_N,
        [Description("AU_NA: Australia - Narrandera")]
        AU_NA,
        [Description("AU_ND: Australia - Goondiwindi")]
        AU_ND,
        [Description("AU_NO: Australia - Northam")]
        AU_NO,
        [Description("AU_NR: Australia - Naracoorte")]
        AU_NR,
        [Description("AU_OB: Australia - Oberon")]
        AU_OB,
        [Description("AU_OR: Australia - Orange")]
        AU_OR,
        [Description("AU_P: Australia - Portland")]
        AU_P,
        [Description("AU_PA: Australia - Cowra")]
        AU_PA,
        [Description("AU_PL: Australia - Port Lincoln")]
        AU_PL,
        [Description("AU_Q: Australia - Yarrawonga")]
        AU_Q,
        [Description("AU_QU: Australia - Queanbeyan")]
        AU_QU,
        [Description("AU_R: Australia - GOULBURN")]
        AU_R,
        [Description("AU_S: Australia - SYDNEY")]
        AU_S,
        [Description("AU_SG: Australia - St George")]
        AU_SG,
        [Description("AU_SH: Australia - Shepparton")]
        AU_SH,
        [Description("AU_SK: Australia - Skipton")]
        AU_SK,
        [Description("AU_SW: Australia - Swan Hill")]
        AU_SW,
        [Description("AU_SY: Australia - Seymour")]
        AU_SY,
        [Description("AU_T: Australia - Inverell")]
        AU_T,
        [Description("AU_TE: Australia - Temora")]
        AU_TE,
        [Description("AU_U: Australia - Auburn")]
        AU_U,
        [Description("AU_UR: Australia - Uralla")]
        AU_UR,
        [Description("AU_V: Australia - Forbes")]
        AU_V,
        [Description("AU_W: Australia - Tamworth")]
        AU_W,
        [Description("AU_WA: Australia - Warren")]
        AU_WA,
        [Description("AU_WG: Australia - Walgett")]
        AU_WG,
        [Description("AU_WL: Australia - Walcha")]
        AU_WL,
        [Description("AU_WN: Australia - Wellington")]
        AU_WN,
        [Description("AU_WR: Australia - Wangaratta")]
        AU_WR,
        [Description("AU_WW: Australia - West Wyalong")]
        AU_WW,
        [Description("AU_X: Australia - Ararat")]
        AU_X,
        [Description("AU_Y: Australia - Albury")]
        AU_Y,
        [Description("AU_YA: Australia - Yass")]
        AU_YA,
        [Description("AU_YM: Australia - Yarram")]
        AU_YM,
        [Description("AU_YO: Australia - Young")]
        AU_YO,
        [Description("AU_Z: Australia - Albany")]
        AU_Z,

        //Overseas
        [Description("OS_ZA: Overseas - Australia")]
        OS_ZA,
        [Description("OS_ZB: Overseas - Belgium")]
        OS_ZB,
        [Description("OS_ZC: Overseas - Christchurch - New Zealand")]
        OS_ZC,
        [Description("OS_ZD: Overseas - Dunedin - New Zealand")]
        OS_ZD,
        [Description("OS_ZE: Overseas - England")]
        OS_ZE,
        [Description("OS_ZF: Overseas - France")]
        OS_ZF,
        [Description("OS_ZG: Overseas - Germany")]
        OS_ZG,
        [Description("OS_ZH: Overseas - Blumenthal - Germany")]
        OS_ZH,
        [Description("OS_ZI: Overseas - Italy")]
        OS_ZI,
        [Description("OS_ZJ: Overseas - Biella - Italy")]
        OS_ZJ,
        [Description("OS_ZK: Overseas - Grisignano - Italy")]
        OS_ZK,
        [Description("OS_ZL: Overseas - Mosgiel - New Zealand")]
        OS_ZL,
        [Description("OS_ZM: Overseas - Nanjing - China")]
        OS_ZM,
        [Description("OS_ZN: Overseas - Netherlands")]
        OS_ZN,
        [Description("OS_ZO: Overseas - Keelung - Taiwan")]
        OS_ZO,
        [Description("OS_ZP: Overseas - Shanghai - China")]
        OS_ZP,
        [Description("OS_ZQ: Overseas - Qingdao - China")]
        OS_ZQ,
        [Description("OS_ZR: Overseas - Zhangjiagang - China")]
        OS_ZR,
        [Description("OS_ZS: Overseas - South Africa")]
        OS_ZS,
        [Description("OS_ZT: Overseas - Timaru - New Zealand")]
        OS_ZT,
        [Description("OS_ZU: Overseas - USA")]
        OS_ZU,
        [Description("OS_ZV: Overseas - Invercargill - New Zealand")]
        OS_ZV,
        [Description("OS_ZW: Overseas - Wellington - New Zealand")]
        OS_ZW,
        [Description("OS_ZX: Overseas - Napier - New Zealand")]
        OS_ZX,
        [Description("OS_ZY: Overseas - Ashburton - New Zealand")]
        OS_ZY,
        [Description("OS_ZZ: Overseas - New Zealand")]
        OS_ZZ,

        //New Zealand
        [Description("NZ_A: New Zealand - Auckland")]
        NZ_A,
        [Description("NZ_AW: New Zealand - Awatoto")]
        NZ_AW,
        [Description("NZ_B: New Zealand - Cambridge")]
        NZ_B,
        [Description("NZ_BL: New Zealand - Blenheim")]
        NZ_BL,
        [Description("NZ_BT: New Zealand - Bunnythorpe")]
        NZ_BT,
        [Description("NZ_C: New Zealand - Christchurch")]
        NZ_C,
        [Description("NZ_CV: New Zealand - Clive")]
        NZ_CV,
        [Description("NZ_D: New Zealand - Dunedin")]
        NZ_D,
        [Description("NZ_F: New Zealand - Feilding")]
        NZ_F,
        [Description("NZ_FA: New Zealand - Fairlie")]
        NZ_FA,
        [Description("NZ_G: New Zealand - Gisborne")]
        NZ_G,
        [Description("NZ_GD: New Zealand - Geraldine")]
        NZ_GD,
        [Description("NZ_GO: New Zealand - Gore")]
        NZ_GO,
        [Description("NZ_HA: New Zealand - Hawera")]
        NZ_HA,
        [Description("NZ_HS: New Zealand - Hastings")]
        NZ_HS,
        [Description("NZ_I: New Zealand - Invercargill")]
        NZ_I,
        [Description("NZ_J: New Zealand - Tapanui")]
        NZ_J,
        [Description("NZ_K: New Zealand - Te Kuiti")]
        NZ_K,
        [Description("NZ_KA: New Zealand - Kakariki")]
        NZ_KA,
        [Description("NZ_KP: New Zealand - Kaiapoi")]
        NZ_KP,
        [Description("NZ_L: New Zealand - Mosgiel")]
        NZ_L,
        [Description("NZ_LO: New Zealand - Longburn")]
        NZ_LO,
        [Description("NZ_LU: New Zealand - Lumsden")]
        NZ_LU,
        [Description("NZ_M: New Zealand - Masterton")]
        NZ_M,
        [Description("NZ_MA: New Zealand - Mangatinoka")]
        NZ_MA,
        [Description("NZ_MK: New Zealand - Motueka")]
        NZ_MK,
        [Description("NZ_MT: New Zealand - Milton")]
        NZ_MT,
        [Description("NZ_MU: New Zealand - Mataura")]
        NZ_MU,
        [Description("NZ_N: New Zealand - Napier")]
        NZ_N,
        [Description("NZ_NE: New Zealand - Nelson")]
        NZ_NE,
        [Description("NZ_O: New Zealand - Oamaru")]
        NZ_O,
        [Description("NZ_OH: New Zealand - Ohinewai")]
        NZ_OH,
        [Description("NZ_OI: New Zealand - Ohai")]
        NZ_OI,
        [Description("NZ_OM: New Zealand - Omakau")]
        NZ_OM,
        [Description("NZ_OT: New Zealand - Otorohonga")]
        NZ_OT,
        [Description("NZ_P: New Zealand - Palmerston North")]
        NZ_P,
        [Description("NZ_PT: New Zealand - Pahiatua")]
        NZ_PT,
        [Description("NZ_PU: New Zealand - Putaruru")]
        NZ_PU,
        [Description("NZ_R: New Zealand - Rotorua")]
        NZ_R,
        [Description("NZ_RG: New Zealand - Rangiora")]
        NZ_RG,
        [Description("NZ_RI: New Zealand - Riwaka")]
        NZ_RI,
        [Description("NZ_S: New Zealand - Ashburton")]
        NZ_S,
        [Description("NZ_SA: New Zealand - Saltwater Creek")]
        NZ_SA,
        [Description("NZ_SH: New Zealand - Shannon")]
        NZ_SH,
        [Description("NZ_SY: New Zealand - Sydney")]
        NZ_SY,
        [Description("NZ_T: New Zealand - Timaru")]
        NZ_T,
        [Description("NZ_TA: New Zealand - Tapanui")]
        NZ_TA,
        [Description("NZ_TE: New Zealand - TeAnau")]
        NZ_TE,
        [Description("NZ_TH: New Zealand - Taihape")]
        NZ_TH,
        [Description("NZ_TP: New Zealand - Te Puke")]
        NZ_TP,
        [Description("NZ_U: New Zealand - Taumaruniu")]
        NZ_U,
        [Description("NZ_V: New Zealand - Dannevirke")]
        NZ_V,
        [Description("NZ_W: New Zealand - Wellington")]
        NZ_W,
        [Description("NZ_WH: New Zealand - Whakatu")]
        NZ_WH,
        [Description("NZ_WI: New Zealand - Whakatu Industrial Park")]
        NZ_WI,
        [Description("NZ_WR: New Zealand - Wairoa")]
        NZ_WR,
        [Description("NZ_WT: New Zealand - Winton")]
        NZ_WT,
        [Description("NZ_WU: New Zealand - Waikuku")]
        NZ_WU,
        [Description("NZ_X: New Zealand - Wanganui")]
        NZ_X,
        [Description("NZ_Y: New Zealand - Whangarei")]
        NZ_Y,
        [Description("NZ_YP: New Zealand - Waipukurau")]
        NZ_YP,
        [Description("NZ_Z: New Zealand - Taupo")]
        NZ_Z
    }

    public enum CentreAustralia
    {
        
    }

    public enum CentreOverseas
    {
        
    }



    /// <summary>
    /// A centre is a town where any activity connected with the wool industry takes place.
    /// The codes used in transmissions are those defined in the Australian Wool Selling Regulation.
    /// In New Zealand, this is the centre in which the wool is sold.
    /// The field is not used in Australia.
    /// </summary>
    public enum CentreNewZealand
    {
        
    }


}
