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
    [Description("This is Centres for Australia. " +
        "A centre is a town where any activity connected with the wool industry takes place. " +
        "The codes used in transmissions are those defined in the Australian Wool Selling Regulation.")]
    public enum CentreCodeAustralia
    {
        //Australia
        [Description("A: Australia - ADELAIDE")]
        A,
        [Description("AD: Australia - Ardlethan")]
        AD,
        [Description("AR: Australia - Armidale (NSW)")]
        AR,
        [Description("AU: Australia - AUSTRALIA (AWEX internal only)")]
        AU,
        [Description("B: Australia - BRISBANE")]
        B,
        [Description("BA: Australia - Benalla")]
        BA,
        [Description("BK: Australia - Bourke")]
        BK,
        [Description("BL: Australia - Ballarat")]
        BL,
        [Description("BM: Australia - Barham")]
        BM,
        [Description("BO: Australia - Boorowa")]
        BO,
        [Description("BR: Australia - Bordertown")]
        BR,
        [Description("BT: Australia - Bathurst")]
        BT,
        [Description("C: Australia - Cooma")]
        C,
        [Description("CA: Australia - Casterton")]
        CA,
        [Description("CB: Australia - Coonabarabran")]
        CB,
        [Description("CC: Australia - Culcairn")]
        CC,
        [Description("CL: Australia - Coleraine")]
        CL,
        [Description("CN: Australia - Condoblin")]
        CN,
        [Description("CO: Australia - Cootamundra")]
        CO,
        [Description("CR: Australia - Corowa")]
        CR,
        [Description("CU: Australia - Cunnamulla")]
        CU,
        [Description("CW: Australia - Crookwell")]
        CW,
        [Description("D: Australia - Bendigo")]
        D,
        [Description("DE: Australia - Deniliquin")]
        DE,
        [Description("DO: Australia - Dubbo")]
        DO,
        [Description("DR: Australia - Canowindra")]
        DR,
        [Description("E: Australia - Echuca")]
        E,
        [Description("ER: Australia - Euroa")]
        ER,
        [Description("ES: Australia - Esperance")]
        ES,
        [Description("F: Australia - FREMANTLE")]
        F,
        [Description("G: Australia - GEELONG")]
        G,
        [Description("GF: Australia - Grenfell")]
        GF,
        [Description("GI: Australia - Glenn Innes")]
        GI,
        [Description("GN: Australia - Gunning")]
        GN,
        [Description("GR: Australia - Griffith")]
        GR,
        [Description("GU: Australia - Guyra")]
        GU,
        [Description("H: Australia - Hobart")]
        H,
        [Description("HA: Australia - Harden")]
        HA,
        [Description("HB: Australia - Holbrook")]
        HB,
        [Description("HM: Australia - Hamilton")]
        HM,
        [Description("HO: Australia - Horsham")]
        HO,
        [Description("HY: Australia - Hay")]
        HY,
        [Description("I: Australia - Narrabri")]
        I,
        [Description("J: Australia - Parkes")]
        J,
        [Description("JA: Australia - Jamestown")]
        JA,
        [Description("K: Australia - Warracknabeal")]
        K,
        [Description("KE: Australia - Kerang")]
        KE,
        [Description("KH: Australia - Keith")]
        KH,
        [Description("KI: Australia - Kangaroo Island")]
        KI,
        [Description("KN: Australia - Kingston")]
        KN,
        [Description("KT: Australia - Katanning")]
        KT,
        [Description("KW: Australia - Wagga Wagga")]
        KW,
        [Description("KY: Australia - Kyneton")]
        KY,
        [Description("L: Australia - LAUNCESTON")]
        L,
        [Description("LC: Australia - Lane Cove (AWEX internal only)")]
        LC,
        [Description("M: Australia - MELBOURNE")]
        M,
        [Description("MA: Australia - Mansfield")]
        MA,
        [Description("MB: Australia - Murray Bridge")]
        MB,
        [Description("MC: Australia - Macarthur")]
        MC,
        [Description("ME: Australia - Melton")]
        ME,
        [Description("MG: Australia - Mount Gambier")]
        MG,
        [Description("MI: Australia - Mildura")]
        MI,
        [Description("MO: Australia - Moree")]
        MO,
        [Description("MR: Australia - Maryborough")]
        MR,
        [Description("MU: Australia - Mudgee")]
        MU,
        [Description("N: Australia - NEWCASTLE")]
        N,
        [Description("NA: Australia - Narrandera")]
        NA,
        [Description("ND: Australia - Goondiwindi")]
        ND,
        [Description("NO: Australia - Northam")]
        NO,
        [Description("NR: Australia - Naracoorte")]
        NR,
        [Description("OB: Australia - Oberon")]
        OB,
        [Description("OR: Australia - Orange")]
        OR,
        [Description("P: Australia - Portland")]
        P,
        [Description("PA: Australia - Cowra")]
        PA,
        [Description("PL: Australia - Port Lincoln")]
        PL,
        [Description("Q: Australia - Yarrawonga")]
        Q,
        [Description("QU: Australia - Queanbeyan")]
        QU,
        [Description("R: Australia - GOULBURN")]
        R,
        [Description("S: Australia - SYDNEY")]
        S,
        [Description("SG: Australia - St George")]
        SG,
        [Description("SH: Australia - Shepparton")]
        SH,
        [Description("SK: Australia - Skipton")]
        SK,
        [Description("SW: Australia - Swan Hill")]
        SW,
        [Description("SY: Australia - Seymour")]
        SY,
        [Description("T: Australia - Inverell")]
        T,
        [Description("TE: Australia - Temora")]
        TE,
        [Description("U: Australia - Auburn")]
        U,
        [Description("UR: Australia - Uralla")]
        UR,
        [Description("V: Australia - Forbes")]
        V,
        [Description("W: Australia - Tamworth")]
        W,
        [Description("WA: Australia - Warren")]
        WA,
        [Description("WG: Australia - Walgett")]
        WG,
        [Description("WL: Australia - Walcha")]
        WL,
        [Description("WN: Australia - Wellington")]
        WN,
        [Description("WR: Australia - Wangaratta")]
        WR,
        [Description("WW: Australia - West Wyalong")]
        WW,
        [Description("X: Australia - Ararat")]
        X,
        [Description("Y: Australia - Albury")]
        Y,
        [Description("YA: Australia - Yass")]
        YA,
        [Description("YM: Australia - Yarram")]
        YM,
        [Description("YO: Australia - Young")]
        YO,
        [Description("Z: Australia - Albany")]
        Z,
        [Description("ZC:Christchurch - New Zealand")]
        ZC,
        [Description("ZD: Dunedin - New Zealand")]
        ZD,
        [Description("ZH: Blumenthal - Germany")]
        ZH,
        [Description("ZJ: Biella - Italy")]
        ZJ,
        [Description("ZK: Grisignano - Italy")]
        ZK,
        [Description("ZL: Mosgiel - New Zealand")]
        ZL,
        [Description("ZM: Nanjing - China")]
        ZM,
        [Description("ZO: Keelung - Taiwan")]
        ZO,
        [Description("ZP: Shanghai - China")]
        ZP,
        [Description("ZQ: Qingdao - China")]
        ZQ,
        [Description("ZR: Zhangjiagang - China")]
        ZR,
        [Description("ZT: Timaru - New Zealand")]
        ZT,
        [Description("ZV: Invercargill - New Zealand")]
        ZV,
        [Description("ZW:Wellington - New Zealand")]
        ZW,
        [Description("ZX: Napier – New Zealand")]
        ZX,
        [Description("ZY: Ashburton – New Zealand")]
        ZY,

    }
}
