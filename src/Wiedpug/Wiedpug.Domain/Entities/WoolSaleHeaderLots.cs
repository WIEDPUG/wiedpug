using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using static System.Collections.Specialized.BitVector32;

namespace Wiedpug.Domain.Entities
{
    public class WoolSaleHeaderLots
    {
        [Required]
        public required int Season { get; set; }

        [Required]
        public required SaleIdentity SaleIdentity { get; set; }

        /// <summary>
        /// The centre (code) representing the location at which the wool is stored (relevant to the intended use of the document). 
        /// For example, the Centre- Storage against a lot in the AC or ACU is the location of the wool where the buyer would expect to take delivery.
        /// </summary>
        [Required]
        public required string CentreStorage { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string SaleDate { get; set; }

        [Required]
        public required WoolState WoolState { get; set; }

        [Required]
        public required PackType PackType { get; set; }

        /// <summary>
        /// The Code for the currency in which the sale was made. To obtain the current code list please use the Commonwealth Bank Currency Codes on their website
        /// </summary>
        [Required]
        [MaxLength(3)]
        public required string Currency { get; set; }

        [Required]
        public required WeightUnit WeightUnit { get; set; }

        /// <summary>
        /// This is the published rate for the charge levied by the broker to the buyer for each bale purchased and is included in the last cost of the wool.
        /// It will not include freight if freight is listed separately in the Freight Charge field, if freight is not listed in the Freight Charge field it will include freight. 
        /// In Australia it will always include freight as the Freight Charge field is not used.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double PostSaleCharge { get; set; }

        [Required]
        public required CalculationBasis CalculationBasis { get; set; }

        /// <summary>
        /// If specified, this is not part of the last cost of the wool. 
        /// If a freight charge is not included in the post Sale Charge, then the freight charge is the charge levied by the broker should the buyer request that the broker transport the wool to the nearest designated area (usually a shipping port). 
        /// Freight Charge is not used in Australia.
        /// </summary>
        public double? FreightCharge { get; set; }
        public double? FreightRebate { get; set; }

        /// <summary>
        /// Any charge made for a lot which is not covered by the Post Sale Charge or the Freight charge per Bale fields.
        /// </summary>
        public double? ChargePerLot { get; set; }
        public string? InvoiceNumber { get; set; }
        
        [Required]
        public required CatalogueSection CatalogueSection { get; set; }

        /// <summary>
        /// The code for the broker who will raise the invoice for the wool
        /// </summary>
        [Required]
        public required string InvoicingOrganisation { get; set; }

        /// <summary>
        /// Indicates whether the related section of the catalogue transmission is expected to have more amendments transmitted or is the final transmission for that section. 
        /// `true` = Final Catalogue. `false` = Not Final Catalogue
        /// </summary>
        [Required]
        public required bool IsFinalCatalogue { get; set; }

        /// <summary>
        /// The broker that is responsible for releasing the wool out of the store
        /// </summary>
        [Required]
        public required string ReleasingOrganisation { get; set; }

        [Required]
        public required string SellingOrganisation { get; set; }

        [Required]
        public required WoolTypeGroup WoolTypeGroup { get; set; }
        
        [Required]
        public required Centre CentreCatalogue { get; set; }

        [Required]
        public required DeliveryBasis DeliveryBasis { get; set; }

        /// <summary>
        /// Inclusion of the Delivery Area Centre Code is Mandatory when the Post Sale Service Charge includes delivery to a nominated area and a “D” is included in the Delivery Basis Field.
        /// </summary>
        public Centre? CentreDelivery { get; set; }

        /// <summary>
        /// This field is to be used when the PSC includes optional delivery to a second area.
        /// </summary>
        public Centre? AlternateDelivery { get; set; }
    }
}
