using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [Description("The registered four character or less quality scheme code. To obtain the current code list please go to this URL: http://www.awex.com.au/standards/catalogue/")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum QualityScheme
    {
        [Description("AustralianSuperfineWoolgrowerAssociation: Code: ASWG. Australian Superfine Woolgrower Association (Member)")]
        AustralianSuperfineWoolgrowerAssociation,

        [Description("Authentico: Code: AUTH. Authentico")]
        Authentico,

        [Description("BetterChoices: Code: BETC. Better Choices (Pain Mitigation)")]
        BetterChoices,

        [Description("BioClip: Code: BIOC. BioClip (Biologically Harvested)")]
        BioClip,

        [Description("Dalcare3: Code: DAL3. Dalcare-3")]
        Dalcare3,

        [Description("EUEcoLabel: Code: EUEC. EU Eco label (meets EU Eco standards)")]
        EUEcoLabel,

        [Description("MerinoTechWA: Code: MTEC. Merino Tech WA")]
        MerinoTechWA,

        [Description("AustralianCertifiedOrganic: Code: ACO. Organic - Australian Certified Organic")]
        AustralianCertifiedOrganic,

        [Description("DemeterBiodynamicAgricultureAustOrganic: Code: DBAA. Organic - Demeter Biodynamic Agriculture Aust.")]
        DemeterBiodynamicAgricultureAustOrganic,

        [Description("USACertifiedOrganic: Code: USA. Organic - Meets USA Certification requirements")]
        USACertifiedOrganic,

        [Description("NationalAssociationForSustainableAgricultureOrganic: Code: NASA. Organic - National Association for Sustainable Agriculture Aust.")]
        NationalAssociationForSustainableAgricultureOrganic,

        [Description("SouthernCrossCertifiedOrganic: Code: SXC. Organic - Southern Cross Certified")]
        SouthernCrossCertifiedOrganic,

        [Description("ResponsibleWoolStandard: Code: RWS. Responsible Wool Standard")]
        ResponsibleWoolStandard,

        [Description("SchuteBellFibreCare: Code: SBFC. Schute Bell Fibre Care")]
        SchuteBellFibreCare,

        [Description("SustainaWOOL: Code: SW. SustainaWOOL")]
        SustainaWOOL,

        [Description("SustainaWOOLGold: Code: SWAU. SustainaWOOL Gold")]
        SustainaWOOLGold,

        [Description("TraprockQMSOrTIMS: Code: TQMS. Traprock QMS/TIMS")]
        TraprockQMSOrTIMS,

        [Description("FarmAssuranceProgram: Code: FAP. Farm Assurance Program")]
        FarmAssuranceProgram,

        [Description("PGGWrightsonIntegrityAssured: Code: PWIA. PGG Wrightson Integrity Assured")]
        PGGWrightsonIntegrityAssured,

        [Description("WoolcareFernmark: Code: FERN. Woolcare Fernmark")]
        WoolcareFernmark
    }
}
