namespace Wiedpug.Domain.Shared.Constants
{
    public class RegexPattern
    {
        public const string DATE_ISO8601 = @"/(?:[1-9]\d{3}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\d|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[1-9]\d(?:0[48]|[2468][048]|[13579][26])|(?:[2468][048]|[13579][26])00)-02-29)$/";
        public const string DATE_AND_TIME_WITH_OFFSET_ISO8601 = @"/(?:[1-9]\d{3}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\d|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[1-9]\d(?:0[48]|[2468][048]|[13579][26])|(?:[2468][048]|[13579][26])00)-02-29)T([01][0-9]|2[0-3]):([0-5][0-9]):([0-5][0-9])[+-]?(((([0][0-9])|([1][0-3])):(([03][0])|([14][5])))|14:00)$/";
        public const string DECIMAL_TWO_DIGITS = @"^\d+(\.\d{2})?$";
        public const string DECIMAL_ONE_DIGITS = @"^\d+(\.\d{1})?$";
        public const string DECIMAL_FOUR_DIGITS = @"^\d+(\.\d{4})?$";
        public const string DECIMAL_SIX_DIGITS = @"^\d+(\.\d{6})?$";
        public const string STRING_SIX_DIGITS_BEFORE_DECIMAL_POINT = @"^\d{6}$";
    }

    public class WoolState
    {
        public const string Greasy = "1";
        public const string Dead = "2";
        public const string Slipe = "3";
        public const string Scoured = "4";
        public const string Carbonised = "5";
        public const string WoolTops = "6";
        public const string WoolNoils = "7";
        public const string CardedSliver = "8";
        public const string OtherProcessedWool = "9";
        public const string Alpaca = "A";
        public const string Cashmere = "C";
        public const string Mohair = "M";
    }

    public class PackType
    {
        public const string StandardFarmBale = "0";
        public const string BagButt = "1";
        public const string LightweightBale = "2";
        public const string JumboBale = "3";
        public const string SingleBalesNormalDensity = "4";
        public const string SingleBalesHighDensity = "5";
        public const string SingleBalesSuperHighDensity = "6";
        public const string ThreeBaleTripackSuperHighDensity = "7";
        public const string TwoBaleTripackSuperHighDensity = "8";
        public const string UBales = "9";
        public const string FourOrSixBaleUnitisedNormalDensity = "A";
        public const string FourOrSixBaleUnitisedHighDensity = "B";
        public const string FourOrSixBaleUnitisedSuperHighDensity = "C";
        public const string TwoBaleModule = "D";
        public const string J9SizeBaleUsedForScouredWool = "E";
        public const string J12SizeBaleUsedForScouredWool = "F";
        public const string Mixed = "Z";
    }

    public class DarkAndMedullatedFibreRisk
    {
        public const string ErrorInProcessing = "E";

        public const string NotApplicable = "N";

        public const string NotDeclared = "D";

        public const string RiskLevel1 = "1";

        public const string RiskLevel2 = "2";

        public const string RiskLevel3 = "3";

        public const string RiskLevel4 = "4";

        public const string RiskLevel5 = "5";

        public const string RiskLevel6 = "6";
    }

    public class CombinationFlag
    {
        public const string NormalCombination = "N";
        public const string ASX24Combination = "S";
        public const string ASX19554WCombination = "4";
        public const string ASX21055WCombination = "5";
        public const string ASX22656WCombination = "6";
        public const string ASX19554WASX21055WASX22656WCombination = "7";
        public const string ASX19554WASX21055WCombination = "8";
        public const string ASX21055WASX22656WCombination = "9";
        public const string ICAPWoolContractChinaType54P = "A";
        public const string ICAPWoolContractChinaType54 = "B";
        public const string ICAPWoolContractChinaType55 = "C";
        public const string ICAPWoolContractChinaType56 = "D";
        public const string ICAPWoolContractChinaType424 = "E";
        public const string ICAPWoolContractChinaTypeStandard = "F";
    }
}
