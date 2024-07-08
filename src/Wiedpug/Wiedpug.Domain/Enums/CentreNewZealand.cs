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
    [Description("This is Centres for New Zealand. " +
        "A centre is a town where any activity connected with the wool industry takes place. " +
        "The codes used in transmissions are those defined in the Australian Wool Selling Regulation.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CentreNewZealand
    {
        //New Zealand
        [Description("A: New Zealand - Auckland")]
        A,
        [Description("AW: New Zealand - Awatoto")]
        AW,
        [Description("B: New Zealand - Cambridge")]
        B,
        [Description("BL: New Zealand - Blenheim")]
        BL,
        [Description("BT: New Zealand - Bunnythorpe")]
        BT,
        [Description("C: New Zealand - Christchurch")]
        C,
        [Description("CV: New Zealand - Clive")]
        CV,
        [Description("D: New Zealand - Dunedin")]
        D,
        [Description("F: New Zealand - Feilding")]
        F,
        [Description("FA: New Zealand - Fairlie")]
        FA,
        [Description("G: New Zealand - Gisborne")]
        G,
        [Description("GD: New Zealand - Geraldine")]
        GD,
        [Description("GO: New Zealand - Gore")]
        GO,
        [Description("HA: New Zealand - Hawera")]
        HA,
        [Description("HS: New Zealand - Hastings")]
        HS,
        [Description("I: New Zealand - Invercargill")]
        I,
        [Description("J: New Zealand - Tapanui")]
        J,
        [Description("K: New Zealand - Te Kuiti")]
        K,
        [Description("KA: New Zealand - Kakariki")]
        KA,
        [Description("KP: New Zealand - Kaiapoi")]
        KP,
        [Description("L: New Zealand - Mosgiel")]
        L,
        [Description("LO: New Zealand - Longburn")]
        LO,
        [Description("LU: New Zealand - Lumsden")]
        LU,
        [Description("M: New Zealand - Masterton")]
        M,
        [Description("MA: New Zealand - Mangatinoka")]
        MA,
        [Description("MK: New Zealand - Motueka")]
        MK,
        [Description("MT: New Zealand - Milton")]
        MT,
        [Description("MU: New Zealand - Mataura")]
        MU,
        [Description("N: New Zealand - Napier")]
        N,
        [Description("NE: New Zealand - Nelson")]
        NE,
        [Description("O: New Zealand - Oamaru")]
        O,
        [Description("OH: New Zealand - Ohinewai")]
        OH,
        [Description("OI: New Zealand - Ohai")]
        OI,
        [Description("OM: New Zealand - Omakau")]
        OM,
        [Description("OT: New Zealand - Otorohonga")]
        OT,
        [Description("P: New Zealand - Palmerston North")]
        P,
        [Description("PT: New Zealand - Pahiatua")]
        PT,
        [Description("PU: New Zealand - Putaruru")]
        PU,
        [Description("R: New Zealand - Rotorua")]
        R,
        [Description("RG: New Zealand - Rangiora")]
        RG,
        [Description("RI: New Zealand - Riwaka")]
        RI,
        [Description("S: New Zealand - Ashburton")]
        S,
        [Description("SA: New Zealand - Saltwater Creek")]
        SA,
        [Description("SH: New Zealand - Shannon")]
        SH,
        [Description("SY: New Zealand - Sydney")]
        SY,
        [Description("T: New Zealand - Timaru")]
        T,
        [Description("TA: New Zealand - Tapanui")]
        TA,
        [Description("TE: New Zealand - TeAnau")]
        TE,
        [Description("TH: New Zealand - Taihape")]
        TH,
        [Description("TP: New Zealand - Te Puke")]
        TP,
        [Description("U: New Zealand - Taumaruniu")]
        U,
        [Description("V: New Zealand - Dannevirke")]
        V,
        [Description("W: New Zealand - Wellington")]
        W,
        [Description("WH: New Zealand - Whakatu")]
        WH,
        [Description("WI: New Zealand - Whakatu Industrial Park")]
        WI,
        [Description("WR: New Zealand - Wairoa")]
        WR,
        [Description("WT: New Zealand - Winton")]
        WT,
        [Description("WU: New Zealand - Waikuku")]
        WU,
        [Description("X: New Zealand - Wanganui")]
        X,
        [Description("Y: New Zealand - Whangarei")]
        Y,
        [Description("YP: New Zealand - Waipukurau")]
        YP,
        [Description("Z: New Zealand - Taupo")]
        Z
    }
}
