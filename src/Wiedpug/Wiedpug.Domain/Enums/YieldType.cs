using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Description("Yield Type indicates either the type of yield transmitted in another field or record, or the type of yield used to arrive at the value in another field.")]
    public enum YieldType
    {
        [Description("Reserved: Code: 1. RESERVED")]
        Reserved = 1,

        [Description("Reserved_1: Code: 2. RESERVED")]
        Reserved_1 = 2,

        [Description("Estimated: Code: 3. Estimated.")]
        Estimated = 3,

        [Description("SchlumbergerCombedDry1PercentTFM: Code: 4. Schlumberger Combed Dry (1% TFM)")]
        SchlumbergerCombedDry1PercentTFM = 4,

        [Description("SchlumbergerCombedDry2PercentTFM: Code: 5. Schlumberger Combed Dry (2% TFM)")]
        SchlumbergerCombedDry2PercentsTFM = 5,

        [Description("NobleCombedInOil: Code: 7. Noble Combed in Oil")]
        NobleCombedInOil = 7,

        [Description("IWTOScouredYieldAt16PercentsRegain: Code: 8. IWTO Scoured Yield at 16% Regain")]
        IWTOScouredYieldAt16PercentsRegain = 8,

        [Description("IWTOScouredYieldAt17PercentsRegain: Code: 9. IWTO Scoured Yield at 17% Regain")]
        IWTOScouredYieldAt17PercentsRegain = 9,

        [Description("JapaneseCleanScoured: Code: 10. Japanese Clean Scoured")]
        JapaneseCleanScoured = 10,

        [Description("AustralianCarbonising: Code: 11. Australian Carbonising")]
        AustralianCarbonising = 11,

        [Description("IWTOCleanWoolContentAt17PercentsRegain: Code: 12. IWTO Clean Wool Content, 17% Regain")]
        IWTOCleanWoolContentAt17PercentsRegain = 12,

        [Description("UnitedStatesCustomClean: Code: 13. United States Custom Clean")]
        UnitedStatesCustomClean = 13,

        [Description("CardSliver: Code: 14. Card Sliver")]
        CardSliver = 14,

        [Description("ASTMCleanWoolFibrePresent: Code: 15. ASTM Clean Wool Fibre Present")]
        ASTMCleanWoolFibrePresent = 15,

        [Description("NobleDryCombed: Code: 16. Noble Dry Combed")]
        NobleDryCombed = 16,

        [Description("SchlumbergerCombedInOil4Point6PercentsTFM: Code: 17. Schlumberger Combed in Oil (4.6% TFM)")]
        SchlumbergerCombedInOil4Point6PercentsTFM = 17,

        [Description("NobleCombedDry: Code: 18. Noble Combed Dry")]
        NobleCombedDry = 18,

        [Description("Theoretical Card Sliver: Code: 19. Theoretical Card Sliver")]
        TheoreticalCardSliver = 19,

        [Description("ASTMLaboratoryScouredYield: Code: 20. ASTM Laboratory Scoured Yield")]
        ASTMLaboratoryScouredYield = 20,

        [Description("ConditionedAt12Percnets: Code: 21. Conditioned at 12.00%")]
        ConditionedAt12Percnets = 21,

        [Description("ConditionedAt13Percnets: Code: 22. Conditioned at 13.00%")]
        ConditionedAt13Percnets = 22,

        [Description("ConditionedAt13Point5Percnets: Code: 23. Conditioned at 13.50%")]
        ConditionedAt13Point5Percnets = 23,

        [Description("24: Conditioned at 13.64%")]
        ConditionedAt13Point64Percents = 24,

        [Description("ConditionedAt14Percents: Code: 25. Conditioned at 14.00%")]
        ConditionedAt14Percents = 25,

        [Description("ConditionedAt14Point4Percents: Code: 26. Conditioned at 14.40%")]
        ConditionedAt14Point4Percents = 26,

        [Description("ConditionedAt15Percents: Code: 27. Conditioned at 15.00%")]
        ConditionedAt15Percents = 27,

        [Description("ConditionedAt16Percents: Code: 28. Conditioned at 16.00%")]
        ConditionedAt16Percents = 28,

        [Description("ConditionedAt17Percents: Code: 29. Conditioned at 17.00%")]
        ConditionedAt17Percents = 29,

        [Description("ConditionedAt18Percents: Code: 30. Conditioned at 18.00%")]
        ConditionedAt18Percents = 30,

        [Description("ConditionedAt18Point25Percents: Code: 31. Conditioned at 18.25%")]
        ConditionedAt18Point25Percents = 31,

        [Description("JapaneseCleanScouredAt17Percents: Code: 32. Japanese Clean Scoured at 17%")]
        JapaneseCleanScouredAt17Percents = 32,

        [Description("NewZealandProcessYield: Code: 33. New Zealand Process Yield")]
        NewZealandProcessYield = 33,

        [Description("IWT0SchlumbergerOil: Code: 42. IWT0 Schlumberger Oil T&N (2.0% & T.FM.)")]
        IWT0SchlumbergerOil = 42,

        [Description("IWTOCleanWoolContent: Code: 43. IWTO Clean Wool Content, 16% Regain")]
        IWTOCleanWoolContent = 43
    }
}
