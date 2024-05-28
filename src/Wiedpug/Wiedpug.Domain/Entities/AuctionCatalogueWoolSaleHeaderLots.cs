using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using static System.Collections.Specialized.BitVector32;

namespace Wiedpug.Domain.Entities
{
    public class AuctionCatalogueWoolSaleHeaderLots
    {
        /// <summary>
        /// Two digits e.g. 99
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int Season { get; set; }

        [Required]
        [StringLength(4)]
        public required SaleIdentity SaleIdentity { get; set; }

        /// <summary>
        /// The centre (code) representing the location at which the wool is stored (relevant to the intended use of the document). 
        /// For example, the Centre- Storage against a lot in the AC or ACU is the location of the wool where the buyer would expect to take delivery.
        /// </summary>
        [Required]
        [StringLength(2)]
        public required string CentreStorage { get; set; }

        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>    
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [StringLength(10)]
        public required string SaleDate { get; set; }

        [Required]
        [StringLength(1)]
        public required WoolState WoolState { get; set; }

        [Required]
        [StringLength(1)]
        public required PackType PackType { get; set; }

        /// <summary>
        /// The Code for the currency in which the sale was made. To obtain the current code list please use the Commonwealth Bank Currency Codes on their website
        /// </summary>
        [Required]
        [StringLength(3)]
        public required string Currency { get; set; }

        [Required]
        [StringLength(1)]
        public required WeightUnit WeightUnit { get; set; }

        /// <summary>
        /// This is the published rate for the charge levied by the broker to the buyer for each bale purchased and is included in the last cost of the wool.
        /// It will not include freight if freight is listed separately in the Freight Charge field, if freight is not listed in the Freight Charge field it will include freight. 
        /// In Australia it will always include freight as the Freight Charge field is not used.
        /// Total 5 digits with 2 digits after the decimal point. e.g. 123.76
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public required double PostSaleCharge { get; set; }

        [Required]
        [MaxLength(1)]
        public required CalculationBasis CalculationBasis { get; set; }

        /// <summary>
        /// If specified, this is not part of the last cost of the wool. 
        /// If a freight charge is not included in the post Sale Charge, then the freight charge is the charge levied by the broker should the buyer request that the broker transport the wool to the nearest designated area (usually a shipping port). 
        /// Freight Charge is not used in Australia.
        /// Total 4 digits with 2 digits after the decimal point. e.g. 23.76
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public double? FreightCharge { get; set; }

        /// <summary>
        /// Total 4 digits with 2 digits after the decimal point. e.g. 23.76
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public double? FreightRebate { get; set; }

        /// <summary>
        /// Any charge made for a lot which is not covered by the Post Sale Charge or the Freight charge per Bale fields.
        /// Total 5 digits with 2 digits after the decimal point. e.g. 123.76
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public double? ChargePerLot { get; set; }

        [StringLength(8)]
        public string? InvoiceNumber { get; set; }
        
        [Required]
        [StringLength(4)]
        public required CatalogueSection CatalogueSection { get; set; }

        /// <summary>
        /// The code for the broker who will raise the invoice for the wool
        /// </summary>
        [Required]
        [StringLength(5)]
        public required string InvoicingOrganisation { get; set; }

        /// <summary>
        /// Indicates whether the related section of the catalogue transmission is expected to have more amendments transmitted or is the final transmission for that section. 
        /// `true` = Final Catalogue. `false` = Not Final Catalogue
        /// </summary>
        [Required]
        [StringLength(5)]
        public required bool IsFinalCatalogue { get; set; }

        /// <summary>
        /// The broker that is responsible for releasing the wool out of the store
        /// </summary>
        [Required]
        [StringLength(5)]
        public required string ReleasingOrganisation { get; set; }

        [Required]
        [StringLength(5)]
        public required string SellingOrganisation { get; set; }

        [Required]
        [StringLength(4)]
        public required WoolTypeGroup WoolTypeGroup { get; set; }
        
        [Required]
        [StringLength(6)]
        public required Centre CentreCatalogue { get; set; }

        [Required]
        [StringLength(1)]
        public required DeliveryBasis DeliveryBasis { get; set; }

        /// <summary>
        /// Inclusion of the Delivery Area Centre Code is Mandatory when the Post Sale Service Charge includes delivery to a nominated area and a “D” is included in the Delivery Basis Field.
        /// </summary>
        /// 
        [StringLength(6)]
        public Centre? CentreDelivery { get; set; }

        /// <summary>
        /// This field is to be used when the PSC includes optional delivery to a second area.
        /// </summary>
        /// 
        [StringLength(6)]
        public Centre? AlternateDelivery { get; set; }
    }
}
