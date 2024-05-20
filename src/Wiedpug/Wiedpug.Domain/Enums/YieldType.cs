using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [Description("Yield Type indicates either the type of yield transmitted in another field or record, or the type of yield used to arrive at the value in another field.")]
    public enum YieldType
    {
        [Description("1. RESERVED")]
        Reserved = 1,

        [Description("2. RESERVED")]
        Reserved_1 = 2,

        [Description("3. Estimated.")]
        Estimated = 3,

        [Description("4. Schlumberger Combed Dry (1% TFM)")]
        SchlumbergerCombedDry1PercentTFM = 4,

        [Description("5. Schlumberger Combed Dry (2% TFM)")]
        SchlumbergerCombedDry2PercentsTFM = 5,

        [Description("7. Noble Combed in Oil")]
        NobleCombedInOil = 7,

        [Description("8. IWTO Scoured Yield at 16% Regain")]
        IWTOScouredYieldAt16PercentsRegain = 8,

        [Description("9. IWTO Scoured Yield at 17% Regain")]
        IWTOScouredYieldAt17PercentsRegain = 9,

        [Description("10. Japanese Clean Scoured")]
        JapaneseCleanScoured = 10,

        [Description("11. Australian Carbonising")]
        AustralianCarbonising = 11,

        [Description("12. IWTO Clean Wool Content, 17% Regain")]
        IWTOCleanWoolContentAt17PercentsRegain = 12,

        [Description("13. United States Custom Clean")]
        UnitedStatesCustomClean = 13,

        [Description("14. Card Sliver")]
        CardSliver = 14,

        [Description("15. ASTM Clean Wool Fibre Present")]
        ASTMCleanWoolFibrePresent = 15,

        [Description("16. Noble Dry Combed")]
        NobleDryCombed = 16,

        [Description("17. Schlumberger Combed in Oil (4.6% TFM)")]
        SchlumbergerCombedInOil4Point6PercentsTFM = 17,

        [Description("18. Noble Combed Dry")]
        NobleCombedDry = 18,

        [Description("19. Theoretical Card Sliver")]
        TheoreticalCardSliver = 19,

        [Description("20. ASTM Laboratory Scoured Yield")]
        ASTMLaboratoryScouredYield = 20,

        [Description("21. Conditioned at 12.00%")]
        ConditionedAt12Percnets = 21,

        [Description("22. Conditioned at 13.00%")]
        ConditionedAt13Percnets = 22,

        [Description("23. Conditioned at 13.50%")]
        ConditionedAt13Point5Percnets = 23,

        [Description("24: Conditioned at 13.64%")]
        ConditionedAt13Point64Percents = 24,

        [Description("25. Conditioned at 14.00%")]
        ConditionedAt14Percents = 25,

        [Description("26. Conditioned at 14.40%")]
        ConditionedAt14Point4Percents = 26,

        [Description("27. Conditioned at 15.00%")]
        ConditionedAt15Percents = 27,

        [Description("28. Conditioned at 16.00%")]
        ConditionedAt16Percents = 28,

        [Description("29. Conditioned at 17.00%")]
        ConditionedAt17Percents = 29,

        [Description("30. Conditioned at 18.00%")]
        ConditionedAt18Percents = 30,

        [Description("31. Conditioned at 18.25%")]
        ConditionedAt18Point25Percents = 31,

        [Description("32. Japanese Clean Scoured at 17%")]
        JapaneseCleanScouredAt17Percents = 32,

        [Description("33. New Zealand Process Yield")]
        NewZealandProcessYield = 33,

        [Description("42. IWT0 Schlumberger Oil T&N (2.0% & T.FM.)")]
        IWT0SchlumbergerOil = 42,

        [Description("43. IWTO Clean Wool Content, 16% Regain")]
        IWTOCleanWoolContent = 43
    }
}
