namespace Wiedpug.Domain.Shared.Constants
{
    public class RegexPattern
    {
        /// <summary>
        /// ISO 8601 Standard UTC date format: YYYY-MM-DD
        /// </summary>
        public const string DATE_UTC_ISO8601 = @"((?:19|20)[0-9][0-9])-(0?[1-9]|1[012])-(0?[1-9]|[12][0-9]|3[01])";
        public const string DECIMAL_ONE_DIGIT = @"/^\d+(\.\d{1})?$/";
        public const string DECIMAL_TWO_DIGITS = @"/^\d+(\.\d{2})?$/";
        public const string DECIMAL_THREE_DIGITS = @"/^\d+(\.\d{3})?$/";
        public const string DECIMAL_FOUR_DIGITS = @"/^\d+(\.\d{4})?$/";
        public const string DECIMAL_SIX_DIGITS = @"/^\d+(\.\d{6})?$/";
        public const string STRING_SIX_DIGITS_BEFORE_DECIMAL_POINT = @"^\d{6}$";
        /// <summary>
        /// ISO 8601 Standard UTC datetime format: YYYY-MM-DDTHH:mm:ssZ
        /// </summary>
        ///
        public const string DATE_AND_TIME_UTC_ISO8601 = @"((?:19|20)[0-9][0-9])-(0?[1-9]|1[012])-(0?[1-9]|[12][0-9]|3[01])T([01]\d|2[0-3]):([0-5]\d):([0-5]\d)Z$";
        public const string NUMBER_1_DIGIT = @"-?\d{1}";
        public const string NUMBER_2_DIGITS = @"-?\d{1,2}";
        public const string NUMBER_6_DIGITS = @"-?\d{1,6}";
        public const string NUMBER_10_DIGITS = @"-?\d{1,10}";
        public const string NUMBER_11_DIGITS = @"-?\d{1,11}";
        public const string NUMBER_3_DIGITS = @"-?\d{1,3}";
        public const string NUMBER_4_DIGITS = @"-?\d{1,4}";
        public const string NUMBER_5_DIGITS = @"-?\d{1,5}";
        public const string NUMBER_7_DIGITS = @"-?\d{1,7}";
        public const string NUMBER_8_DIGITS = @"-?\d{1,8}";
        public const string NUMBER_9_DIGITS = @"-?\d{1,9}";
        public const string NUMBERS = @"^[0-9]+$";
        public const string ABN_NUMBER_11_DIGITS = @"^\d{11}";
        /// <summary>
        /// Total 4 digits, 2 digits after the decimal point
        /// </summary>
        public const string DECIMAL_4_2 = @"^-?\d{1,2}(\.\d{2})?$";
        /// <summary>
        /// Total 5 digits, 2 digits after the decimal point
        /// </summary>
        public const string DECIMAL_5_2 = @"^-?\d{1,3}(\.\d{2})?$";
        /// <summary>
        /// Total 4 digits, 3 digits after the decimal point
        /// </summary>
        public const string DECIMAL_4_3 = @"^-?\d{1}(\.\d{3})?$";
        /// <summary>
        /// Total 4 digits, 1 digits after the decimal point
        /// </summary>
        public const string DECIMAL_4_1 = @"^-?\d{1,3}(\.\d{1})?$";
        /// <summary>
        /// Total 3 digits, 1 digits after the decimal point
        /// </summary>
        public const string DECIMAL_3_1 = @"^-?\d{1,2}(\.\d{1})?$";
        public const string DECIMAL_3_2 = @"^-?\d{1}(\.\d{2})?$";
        public const string DECIMAL_12_2 = @"^-?\d{1,10}(\.\d{2})?$";
        /// <summary>
        /// Total 16 digits, 6 digits after the decimal point
        /// </summary>
        public const string DECIMAL_16_6 = @"^-?\d{1,10}(\.\d{6})?$";
        /// <summary>
        /// Total 15 digits, 6 digits after the decimal point
        /// </summary>
        public const string DECIMAL_15_6 = @"^-?\d{1,9}(\.\d{6})?$";
        /// <summary>
        /// Total 6 digits, 4 digits after the decimal point
        /// </summary>
        public const string DECIMAL_6_4 = @"^-?\d{1,2}(\.\d{4})?$";
        public const string DECIMAL_6_1 = @"^-?\d{1,5}(\.\d{1})?$";
        /// <summary>
        /// Total 6 digits, 2 digits after the decimal point
        /// </summary>
        public const string DECIMAL_6_2 = @"^-?\d{1,4}(\.\d{2})?$";
        /// <summary>
        /// Total 10 digits, 2 digits after the decimal point
        /// </summary>
        public const string DECIMAL_10_2 = @"^-?\d{1,8}(\.\d{2})?$";
        /// <summary>
        /// Total 9 digits, 2 digits after the decimal point
        /// </summary>
        public const string DECIMAL_9_2 = @"^-?\d{1,7}(\.\d{2})?$";
        /// <summary>
        /// Total 12 digits, 2 digits after the decimal point
        /// </summary>
        public const string DECIMAL_12_6 = @"^-?\d{1,6}(\.\d{6})?$";

        /// <summary>
        /// Total 8 digits, 2 digits after the decimal point
        /// </summary>
        public const string DECIMAL_8_2 = @"^-?\d{1,6}(\.\d{2})?$";
    }
}
