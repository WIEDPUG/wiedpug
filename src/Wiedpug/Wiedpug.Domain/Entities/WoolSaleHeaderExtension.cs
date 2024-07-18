using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class WoolSaleHeaderExtension
    {
        /// <summary>
        /// This is the organisation store that is storing the wool. 
        /// Note: If there is more than one organisation in a centre, then separate AWEX codes are required for each store.
        /// It is not necessarily the same as the Releasing Organisation.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required Organisation StorageOrganisation { get; set; } // FIELD NUMBER 3 - Storage Organisation - Start: 3, Size: 5, Data Type: AN, Justification: L, Requirement Designator: R, Value: '11'

        /// <summary>
        /// Used to provide more details on location within the Storage Organisations facility - such as street address, warehouse number etc. – to assist delivery.
        /// </summary>
        [MinLength(1)]
        [MaxLength(15)]
        public string? StorageDescription { get; set; } // FIELD NUMBER 4 - Storage Description - Start: 8, Size: 15, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// The date on which payment is due. Also known as Prompt Date.
        /// Date value in ISO 8601 standard UTC format. e.g. 2024-03-21
        /// </summary>
        /// 
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string PaymentDueDate { get; set; } // FIELD NUMBER 5 - Payment Due Date - Start: 24, Size: 6, Data Type: Date, Justification: L, Requirement Designator: O

        /// <summary>
        /// Total 4 digits with 2 digits after the decimal point. e.g. 23.76
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public required double DiscountRate { get; set; } // FIELD NUMBER 6 - Discount Rate - Start: 30, Size: 4, Data Type: D2, Justification: F, Requirement Designator: M

        /// <summary>
        ///  2 digits number. e.g. 23
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int MaximumDaysDiscount { get; set; } // FIELD NUMBER 7 - Maximum Days Discount - Start: 34, Size: 2, Data Type: N, Justification: R, Requirement Designator: M

        /// <summary>
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string DateStorageChargeCommences { get; set; } // FIELD NUMBER 8 - Date Storage Charge Commences - Start: 36, Size: 6, Data Type: Date, Justification: F, Requirement Designator: M

        /// <summary>
        /// Total 4 digits with 3 digits after the decimal point. e.g. 23.76
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_4_3)]
        public required double StorageChargePerBalePerDay { get; set; } // FIELD NUMBER 9 - Storage Charge Per Bale/Day - Start: 42, Size: 4, Data Type: D3, Justification: R, Requirement Designator: M

        /// <summary>
        /// Total 4 digits with 2 digits after the decimal point. e.g. 23.76
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public required double PenaltyInterestRate { get; set; } // FIELD NUMBER 10 - Penalty Interest Rate - Start: 46, Size: 4, Data Type: D2, Justification: R, Requirement Designator: M

        /// <summary>
        /// The first date on which the wool is available for purchase.
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21. 
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? LotAvailableDate { get; set; } // FIELD NUMBER 11 - Lot Available Date - Start: 50, Size: 6, Data Type: Date, Justification: F, Requirement Designator: O

        /// <summary>
        /// The total (extended) amount of Post Sale Charge Rebate for the Lot. 
        /// This value is provided where a value in the Post Sale Charge Rebate field exists (11A)
        /// Total 5 digits with 2 digits after the decimal point. e.g. 123.76
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public double? PostSaleChargeRebate { get; set; } // FIELD NUMBER 12 - Post Sale Charge Rebate - Start: 56, Size: 5, Data Type: D2, Justification: R, Requirement Designator: O
    }
}
