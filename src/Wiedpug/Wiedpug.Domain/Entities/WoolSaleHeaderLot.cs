using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;
using static System.Collections.Specialized.BitVector32;

namespace Wiedpug.Domain.Entities
{
    public class WoolSaleHeaderLot
    {
        /// <summary>
        /// Two digits e.g. 99
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int Season { get; set; }

        /// <summary>
        /// A group field of SellingCentre/Type and Sale Number
        ///
        /// From: The current value that the Sale Identity is to be changed from.
        ///
        /// To: The new value that the Sale Identity is to be changed to.
        ///
        /// SellingCentre/Type can be one of the following code:
        ///
        /// SellingCentre/Type (New Zealand):
        ///
        /// C: Christchurch; N: Napier.
        ///
        /// SellingCentre/Type (Australia):
        ///
        /// A: Adelaide; AU: Australia; B: Brisbane; F: Fremantle; G: Geelong; L: Launceston; M: Melbourne; N: Newcastle; R: Goulburn; S: Sydney; PS: Private Sales; T: Auctions Plus Sales.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(4)]
        public required SaleIdentity SaleIdentity { get; set; }

        /// <summary>
        /// The centre (code) representing the location at which the wool is stored (relevant to the intended use of the document). For example, the
        /// Centre- Storage against a lot in the Catalogue is the location of the wool where the buyer would expect to take delivery.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required Centre CentreStorage { get; set; }

        /// <summary>
        /// The date on which the wool was sold.
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD).
        /// </summary>    
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string SaleDate { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required WoolState WoolState { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public PackType? PackType { get; set; }

        /// <summary>
        /// This is the published rate for the charge levied by the broker to the buyer for each bale purchased and is included in the last cost of the wool.
        /// 
        /// It will not include freight if freight is listed separately in the Freight Charge field, if freight is not listed in the Freight Charge field it will include freight. 
        /// 
        /// In Australia it will always include freight as the Freight Charge field is not used.
        /// 
        /// Total up to 12 digits with 2 digits after the decimal point. e.g. 123.76
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? PostSaleCharge { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public CalculationBasis? CalculationBasis { get; set; }

        /// <summary>
        /// If specified, this is not part of the last cost of the wool. 
        /// 
        /// If a freight charge is not included in the post Sale Charge, then the freight charge is the charge levied by the broker should the buyer request that the broker transport the wool to the nearest designated area (usually a shipping port).
        /// 
        /// Freight Charge is not used in Australia.
        /// 
        /// Total up to 12 digits with 2 digits after the decimal point. e.g. 23.76
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? FreightCharge { get; set; }

        /// <summary>
        /// Total up to 12 digits with 2 digits after the decimal point. e.g. 23.76
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? FreightRebate { get; set; }

        /// <summary>
        /// Any charge made for a lot which is not covered by the Post Sale Charge or the Freight charge per Bale fields.
        /// </summary>
        ///
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? ChargePerLot { get; set; }

        /// <summary>
        /// Invoice number of the credit
        /// 
        /// </summary>
        [RegularExpression(RegexPattern.NUMBER_8_DIGITS)]
        public string? InvoiceNumber { get; set; }


        [MinLength(1)]
        [MaxLength(4)]
        public CatalogueSection? CatalogueSection { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the related section of the catalogue transmission is expected to have more amendments transmitted or is the final transmission for that section.
        /// 
        /// true: is a final catalogue.
        /// 
        /// false: is not a final catalogue.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsFinalCatalogue { get; set; }

        /// <summary>
        /// The code for the broker who will raise the invoice for the wool.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation InvoicingOrganisation { get; set; }

        /// <summary>
        /// The broker that is responsible for releasing the wool out of the store
        /// </summary>
        [MinLength(1)]
        [MaxLength(8)]
        public Organisation? ReleasingOrganisation { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public Organisation? SellingOrganisation { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        public WoolTypeGroup? WoolTypeGroup { get; set; }

        /// <summary>
        /// The centre (code) used to group lots of wool based on a location. This 
        /// location is typically the core test/weighing centre and is often aligned
        /// with the seller’s Post Sale Charge schedule.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(6)]
        public required Centre CentreCatalogue { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public DeliveryBasis? DeliveryBasis { get; set; }

        /// <summary>
        /// Inclusion of the Delivery Area Centre Code is Mandatory when the Post Sale Service Charge includes delivery to a nominated area and a “D” is included in the Delivery Basis Field.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(6)]
        public Centre? CentreDelivery { get; set; }

        /// <summary>
        /// This field is to be used when the PSC includes optional delivery to a second area.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(6)]
        public Centre? CentreAlternateDelivery { get; set; }


        // Previous WoolSaleHeader - Extension


        /// <summary>
        /// This is the organisation store that is storing the wool.
        /// 
        /// Note: If there is more than one organisation in a centre, then separate AWEX codes are required for each store.
        /// 
        /// It is not necessarily the same as the Releasing Organisation.
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public Organisation? StorageOrganisation { get; set; } // FIELD NUMBER 3 - Storage Organisation - Start: 3, Size: 5, Data Type: AN, Justification: L, Requirement Designator: R, Value: '11'

        /// <summary>
        /// Used to provide more details on location within the Storage Organisations facility - such as street address, warehouse number etc. – to assist delivery.
        /// </summary>
        [MinLength(1)]
        [MaxLength(15)]
        public string? StorageDescription { get; set; } // FIELD NUMBER 4 - Storage Description - Start: 8, Size: 15, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// The date on which payment is due. Also known as Prompt Date.
        /// 
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD).
        /// </summary>
        /// 
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? PaymentDueDate { get; set; }

        /// <summary>
        /// Total 4 digits with 2 digits after the decimal point. e.g. 23.76
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public double? DiscountRate { get; set; } // FIELD NUMBER 6 - Discount Rate - Start: 30, Size: 4, Data Type: D2, Justification: F, Requirement Designator: M

        /// <summary>
        ///  2 digits number. e.g. 23
        /// </summary>
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? MaximumDaysDiscount { get; set; } // FIELD NUMBER 7 - Maximum Days Discount - Start: 34, Size: 2, Data Type: N, Justification: R, Requirement Designator: M

        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? DateStorageChargeCommences { get; set; } // FIELD NUMBER 8 - Date Storage Charge Commences - Start: 36, Size: 6, Data Type: Date, Justification: F, Requirement Designator: M

        [MinLength(7)]
        [MaxLength(7)]
        public StorageChargeCurrency? StorageChargePerBalePerDay { get; set; } // FIELD NUMBER 9 - Storage Charge Per Bale/Day - Start: 42, Size: 4, Data Type: D3, Justification: R, Requirement Designator: M

        /// <summary>
        /// Total 4 digits with 2 digits after the decimal point. e.g. 23.76
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public double? PenaltyInterestRate { get; set; } // FIELD NUMBER 10 - Penalty Interest Rate - Start: 46, Size: 4, Data Type: D2, Justification: R, Requirement Designator: M

        /// <summary>
        /// The first date on which the wool is available for purchase.
        /// 
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21. (YYYY-MM-DD)
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? LotAvailableDate { get; set; } // FIELD NUMBER 11 - Lot Available Date - Start: 50, Size: 6, Data Type: Date, Justification: F, Requirement Designator: O

        /// <summary>
        /// The total (extended) amount of Post Sale Charge Rebate for the Lot.
        /// 
        /// This value is provided where a value in the Post Sale Charge Rebate field exists
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? PostSaleChargeRebate { get; set; }



        // Previous WoolSaleHeader - NonAuction

        /// <summary>
        /// Date and Time value in ISO 8601 standard. e.g. 2024-03-21T19:25:04.000Z
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(24)]
        public string? CatalogueAvailabilityDateTime { get; set; } // FIELD NUMBER 4 - Catalogue Availability Time - Start: 10, Size: 4, Data Type: Time, Justification: L, Requirement Designator: O

        /// <summary>
        /// Refers to when the sale starts
        /// Date and Time value in ISO 8601 standard UTC datetime format. e.g. 2024-03-21T19:25:04+00:00.000Z
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(24)]
        public string? SaleStartDateTime { get; set; } // FIELD NUMBER 5 - Sale Start Date - Start: 14, Size: 6, Data Type: Date, Justification: L, Requirement Designator: O

        /// <summary>
        /// Refers to when the tender/offer sale stops.
        /// Date and Time value in ISO 8601 standard UTC datetime format. e.g. 2024-03-21T19:25:04+00:00.000Z
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(24)]
        public string? SaleEndDateTime { get; set; } // FIELD NUMBER 7 - Sale End Date - Start: 24, Size: 6, Data Type: Date, Justification: L, Requirement Designator: O

        [MinLength(1)]
        [MaxLength(2)]
        public SaleType? SaleType { get; set; } // FIELD NUMBER 9 - Sale Type - Start: 34, Size: 2, Data Type: ID, Justification: L, Requirement Designator: O

        [MinLength(1)]
        [MaxLength(1)]
        public string? ElectronicSaleFlag { get; set; } // FIELD NUMBER 10 - Electronic Sale Flag - Start: 36, Size: 1, Data Type: ID, Justification: L, Requirement Designator: O

        /// <summary>
        /// A boolean value to indicate whether to display reserve price to buyers.
        /// 
        /// true: display.
        /// 
        /// false: not display.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsReservePriceDisplayed { get; set; } // FIELD NUMBER 11 - Reserve Price Display Flag - Start: 37, Size: 1, Data Type: ID, Justification: F, Requirement Designator: O

        /// <summary>
        /// Date and Time value in ISO 8601 standard UTC datetime format. e.g. 2024-03-21T19:25:04.000Z
        /// </summary>
        [DataType(DataType.DateTime)]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(24)]
        public string? TenderSaleReplyDateTime { get; set; }




    }
}
