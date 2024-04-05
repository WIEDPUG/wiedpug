<<<<<<< HEAD
using System.ComponentModel;

namespace Wiedpug.Domain.Enums
{
    [Description("Yield Type indicates either the type of yield transmitted in another field or record, or the type of yield used to arrive at the value in another field.")]
    public enum YieldType
    {
        [Description("1: RESERVED")]
        RESERVED = 1,

        [Description("2: RESERVED")]
        RESERVED_1 = 2,

        [Description("3: ESTIMATED")]
        ESTIMATED = 3,

        [Description("4: Schlumberger Combed Dry (1% TFM)")]
        SCHLUMBERGER_COMBED_DRY_1_TFM = 4,

        [Description("5: Schlumberger Combed Dry (2% TFM)")]
        SCHLUMBERGER_COMBED_DRY_2_TFM = 5,

        [Description("7: Noble Combed in Oil")]
        NOBLE_COMBED_IN_OIL = 7,

        [Description("8: IWTO Scoured Yield at 16% Regain")]
        IWTO_SCOURED_YIELD_AT_16_REGAIN = 8,

        [Description("9: IWTO Scoured Yield at 17% Regain")]
        IWTO_SCOURED_YIELD_AT_17_REGAIN = 9,

        [Description("10: Japanese Clean Scoured")]
        JAPANESE_CLEAN_SCOURED = 10,

        [Description("11: Australian Carbonising")]
        AUSTRALIAN_CARBONISING = 11,

        [Description("12: IWTO Clean Wool Content, 17% Regain")]
        IWTO_CLEAN_WOOL_CONTENT_17_REGAIN = 12,

        [Description("13: United States Custom Clean")]
        UNITED_STATES_CUSTOM_CLEAN = 13,

        [Description("14: Card Sliver")]
        CARD_SLIVER = 14,

        [Description("15: ASTM Clean Wool Fibre Present")]
        ASTM_CLEAN_WOOL_FIBRE_PRESENT = 15,

        [Description("16: Noble Dry Combed")]
        NOBLE_DRY_COMBED = 16,

        [Description("17: Schlumberger Combed in Oil (4.6% TFM)")]
        SCHLUMBERGER_COMBED_IN_OIL_4_6_TFM = 17,

        [Description("18: Noble Combed Dry")]
        NOBLE_COMBED_DRY = 18,

        [Description("19: Theoretical Card Sliver")]
        THEORETICAL_CARD_SLIVER = 19,

        [Description("20: ASTM Laboratory Scoured Yield")]
        ASTM_LABORATORY_SCOURED_YIELD = 20,

        [Description("21: Conditioned at 12.00%")]
        CONDITIONED_AT_12_00 = 21,

        [Description("22: Conditioned at 13.00%")]
        CONDITIONED_AT_13_00 = 22,

        [Description("23: Conditioned at 13.50%")]
        CONDITIONED_AT_13_50 = 23,

        [Description("24: Conditioned at 13.64%")]
        CONDITIONED_AT_13_64 = 24,

        [Description("25: Conditioned at 14.00%")]
        CONDITIONED_AT_14_00 = 25,

        [Description("26: Conditioned at 14.40%")]
        CONDITIONED_AT_14_40 = 26,

        [Description("27: Conditioned at 15.00%")]
        CONDITIONED_AT_15_00 = 27,

        [Description("28: Conditioned at 16.00%")]
        CONDITIONED_AT_16_00 = 28,

        [Description("29: Conditioned at 17.00%")]
        CONDITIONED_AT_17_00 = 29,

        [Description("30: Conditioned at 18.00%")]
        CONDITIONED_AT_18_00 = 30,

        [Description("31: Conditioned at 18.25%")]
        CONDITIONED_AT_18_25 = 31,

        [Description("32: Japanese Clean Scoured at 17%")]
        JAPANESE_CLEAN_SCOURED_AT_17 = 32,

        [Description("33: New Zealand Process Yield")]
        NEW_ZEALAND_PROCESS_YIELD = 33,

        [Description("42: IWT0 Schlumberger Oil T&N (2.0% & T.FM.)")]
        IWT0_SCHLUMBERGER_OIL_T_N_2_0_T_FM = 42,

        [Description("43: IWTO Clean Wool Content, 16% Regain")]
        IWTO_CLEAN_WOOL_CONTENT_16_REGAIN = 43
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    public enum YieldType
    {
        RESERVED1 = 1,
        RESERVED2 = 2,
        ESTIMATED = 3,
        SchlumbergerCombedDry1PercentTFM = 4,
        SchlumbergerCombedDry2PercentTFM = 5,
        NobleCombedInOil = 7,
        IWTOScouredYieldAt16PercentRegain = 8,
        IWTOScouredYieldAt17PercentRegain = 9,
        JapaneseCleanScoured = 10,
        AustralianCarbonising = 11,
        IWTOCleanWoolContent17PercentRegain = 12,
        UnitedStatesCustomClean = 13,
        CardSliver = 14,
        ASTMCleanWoolFibrePresent = 15,
        NobleDryCombed = 16,
        SchlumbergerCombedInOil46PercentTFM = 17,
        NobleCombedDry = 18,
        TheoreticalCardSliver = 19,
        ASTMLaboratoryScouredYield = 20,
        ConditionedAt1200Percent = 21,
        ConditionedAt1300Percent = 22,
        ConditionedAt135Percent = 23,
        ConditionedAt1364Percent = 24,
        ConditionedAt1400Percent = 25,
        ConditionedAt1440Percent = 26,
        ConditionedAt1500Percent = 27,
        ConditionedAt1600Percent = 28,
        ConditionedAt1700Percent = 29,
        ConditionedAt1800Percent = 30,
        ConditionedAt1825Percent = 31,
        JapaneseCleanScouredAt17Percent = 32,
        NewZealandProcessYield = 33,
        IWT0SchlumbergerOilTAndN20PercentAndTFM = 42,
        IWTOCleanWoolContent16PercentRegain = 43
    }

}
>>>>>>> main
