namespace Wiedpug.Domain.Shared.Constants
{
    public class RegexPattern
    {
        public const string DATE_ISO8601 = @"/(?:[1-9]\d{3}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\d|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[1-9]\d(?:0[48]|[2468][048]|[13579][26])|(?:[2468][048]|[13579][26])00)-02-29)$/";
        public const string DATE_AND_TIME_WITH_OFFSET_ISO8601 = @"/(?:[1-9]\d{3}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\d|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[1-9]\d(?:0[48]|[2468][048]|[13579][26])|(?:[2468][048]|[13579][26])00)-02-29)T([01][0-9]|2[0-3]):([0-5][0-9]):([0-5][0-9])[+-]?(((([0][0-9])|([1][0-3])):(([03][0])|([14][5])))|14:00)$/";
        public const string DECIMAL_ONE_DIGIT = @"/^\d+(\.\d{1})?$/";
        public const string DECIMAL_TWO_DIGITS = @"/^\d+(\.\d{2})?$/";
        public const string DECIMAL_THREE_DIGITS = @"/^\d+(\.\d{3})?$/";
        public const string DECIMAL_FOUR_DIGITS = @"/^\d+(\.\d{4})?$/";
        public const string DECIMAL_SIX_DIGITS = @"/^\d+(\.\d{6})?$/";
        public const string STRING_SIX_DIGITS_BEFORE_DECIMAL_POINT = @"^\d{6}$";
        public const string DATE_AND_TIME_UTC_ISO8601 = @"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}Z$";
    }

    public class Regex
    {
        public const string DATE = @" ^ (?<year>\d{2})(?<month>0[1-9]|1[0-2])(?<day>0[1-9]|[12]\d|3[01])$";
        public const string TIME = @"^(?<hour>[01][0-9]|2[0-3])(?<minute>[0-5][0-9])$";
        public const string NUMBERS = @"^[0-9]+$";
        public const string DECIMAL_ONE_DIGIT = @"/^\d+(\.\d{1})?$/";
        public const string DECIMAL_TWO_DIGITS = @"/^\d+(\.\d{2})?$/";
        public const string DECIMAL_THREE_DIGITS = @"/^\d+(\.\d{3})?$/";
        public const string DECIMAL_FOUR_DIGITS = @"/^\d+(\.\d{4})?$/";
        public const string DECIMAL_SIX_DIGITS = @"/^\d+(\.\d{6})?$/";
        public const string STRING_SIX_DIGITS_BEFORE_DECIMAL_POINT = @"^\d{6}$";
    }
}
