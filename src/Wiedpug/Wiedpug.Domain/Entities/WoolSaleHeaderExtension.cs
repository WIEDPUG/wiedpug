using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;

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
        public required string StorageOrganisation { get; set; } // FIELD NUMBER 3 - Storage Organisation - Start: 3, Size: 5, Data Type: AN, Justification: L, Requirement Designator: R, Value: '11'

        /// <summary>
        /// Used to provide more details on location within the Storage Organisations facility - such as street address, warehouse number etc. – to assist delivery.
        /// </summary>
        public string? StorageDescription { get; set; } // FIELD NUMBER 4 - Storage Description - Start: 8, Size: 15, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// The date on which payment is due. Also known as Prompt Date.
        /// Date value in ISO 8601 standard. e.g. 2024-03-21
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public string? PaymentDueDate { get; set; } // FIELD NUMBER 5 - Payment Due Date - Start: 24, Size: 6, Data Type: Date, Justification: L, Requirement Designator: O

        [Required]
        public required double DiscountRate { get; set; } // FIELD NUMBER 6 - Discount Rate - Start: 30, Size: 4, Data Type: D2, Justification: F, Requirement Designator: M

        [Required]
        [Range(0, 99)]
        public required int MaximumDaysDiscount { get; set; } // FIELD NUMBER 7 - Maximum Days Discount - Start: 34, Size: 2, Data Type: N, Justification: R, Requirement Designator: M

        /// <summary>
        /// Date value in ISO 8601 standard. e.g. 2024-03-21
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string DateStorageChargeCommences { get; set; } // FIELD NUMBER 8 - Date Storage Charge Commences - Start: 36, Size: 6, Data Type: Date, Justification: F, Requirement Designator: M

        [Required]
        public required double StorageChargePerBalePerDay { get; set; } // FIELD NUMBER 9 - Storage Charge Per Bale/Day - Start: 42, Size: 4, Data Type: D3, Justification: R, Requirement Designator: M

        [Required]
        public required double PenaltyInterestRate { get; set; } // FIELD NUMBER 10 - Penalty Interest Rate - Start: 46, Size: 4, Data Type: D2, Justification: R, Requirement Designator: M

        /// <summary>
        /// The first date on which the wool is available for purchase.
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public string? LotAvailableDate { get; set; } // FIELD NUMBER 11 - Lot Available Date - Start: 50, Size: 6, Data Type: Date, Justification: F, Requirement Designator: O

        /// <summary>
        /// The total (extended) amount of Post Sale Charge Rebate for the Lot. 
        /// This value is provided where a value in the Post Sale Charge Rebate field exists (11A)
        /// </summary>
        public double? PostSaleChargeRebate { get; set; } // FIELD NUMBER 12 - Post Sale Charge Rebate - Start: 56, Size: 5, Data Type: D2, Justification: R, Requirement Designator: O
    }
}
