using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [Description("These are the codes allocated by the local wool authorities to sectionalise the sale catalogues.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CatalogueSection
    {
        [Description("BLK: ODDS - Black")]
        BLK,

        [Description("DEAD: ODDS - Dead")]
        DEAD,

        [Description("FLC: MFLC - Merino Fleece")]
        FLC,

        [Description("FMG: ODDS - Fellmongered")]
        FMG,

        [Description("ODD: ODDS - Oddments")]
        ODD,

        [Description("SKIN: ODDS - Skin Wool")]
        SKIN,

        [Description("SKT: MSKT - Skirting")]
        SKT,

        [Description("TRAD: MFLC / MSKT / XBFS / ODDS - Traditionally Shown")]
        TRAD,

        [Description("XBD: C XBFS - Crossbred (Flc & Skt)")]
        XBD
    }
}
