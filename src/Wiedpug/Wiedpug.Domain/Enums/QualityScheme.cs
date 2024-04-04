using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [Description("The registered four character or less quality scheme code. To obtain the current code list please go to this URL: http://www.awex.com.au/standards/catalogue/")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum QualityScheme
    {
        [Description("ASWG: Australian Superfine Woolgrower Association (Member)")]
        ASWG,

        [Description("AUTH: Authentico")]
        AUTH,

        [Description("BETC: Better Choices (Pain Mitigation)")]
        BETC,

        [Description("BIOC: BioClip (Biologically Harvested)")]
        BIOC,

        [Description("DAL3: Dalcare-3")]
        DAL3,

        [Description("EUEC: EU Eco label (meets EU Eco standards)")]
        EUEC,

        [Description("MTEC: Merino Tech WA")]
        MTEC,

        [Description("ACO: Organic - Australian Certified Organic")]
        ACO,

        [Description("DBAA: Organic - Demeter Biodynamic Agriculture Aust.")]
        DBAA,

        [Description("USA: Organic - Meets USA Certification requirements")]
        USA,

        [Description("NASA: Organic - National Association for Sustainable Agriculture Aust.")]
        NASA,

        [Description("SXC: Organic - Southern Cross Certified")]
        SXC,

        [Description("RWS: Responsible Wool Standard")]
        RWS,

        [Description("SBFC: Schute Bell Fibre Care")]
        SBFC,

        [Description("SW: SustainaWOOL")]
        SW,

        [Description("SWAU: SustainaWOOL Gold")]
        SWAU,

        [Description("TQMS: Traprock QMS/TIMS")]
        TQMS,

        [Description("FAP: Farm Assurance Program")]
        FAP,

        [Description("PWIA: PGG Wrightson Integrity Assured")]
        PWIA,

        [Description("FERN: Woolcare Fernmark")]
        FERN
    }
}
