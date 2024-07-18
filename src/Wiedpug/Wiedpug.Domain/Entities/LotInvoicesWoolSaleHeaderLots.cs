using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;
using static System.Collections.Specialized.BitVector32;

namespace Wiedpug.Domain.Entities
{
    public class LotInvoicesWoolSaleHeaderLots
    {
        [Required]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int Season { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(4)]
        public required SaleIdentity SaleIdentity { get; set; }

        /// <summary>
        /// The centre (code) representing the location at which the wool is stored (relevant to the intended use of the document). 
        /// For example, the Centre- Storage against a lot in the AC or ACU is the location of the wool where the buyer would expect to take delivery.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required Centre CentreStorage { get; set; }

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

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required PackType PackType { get; set; }

        /// <summary>
        /// The Code for the currency in which the sale was made. To obtain the current code list please use the Commonwealth Bank Currency Codes on their website
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        public required string Currency { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required WeightUnit WeightUnit { get; set; }

        /// <summary>
        /// This is the published rate for the charge levied by the broker to the buyer for each bale purchased and is included in the last cost of the wool.
        /// It will not include freight if freight is listed separately in the Freight Charge field, if freight is not listed in the Freight Charge field it will include freight. 
        /// In Australia it will always include freight as the Freight Charge field is not used.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public required double PostSaleCharge { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required CalculationBasis CalculationBasis { get; set; }

        /// <summary>
        /// If specified, this is not part of the last cost of the wool. 
        /// If a freight charge is not included in the post Sale Charge, then the freight charge is the charge levied by the broker should the buyer request that the broker transport the wool to the nearest designated area (usually a shipping port). 
        /// Freight Charge is not used in Australia.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public double? FreightCharge { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public double? FreightRebate { get; set; }

        /// <summary>
        /// Any charge made for a lot which is not covered by the Post Sale Charge or the Freight charge per Bale fields.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.DECIMAL_5_2)]
        public double? ChargePerLot { get; set; }

        [RegularExpression(RegexPattern.NUMBER_8_DIGITS)]
        public string? InvoiceNumber { get; set; }

        /// <summary>
        /// The code for the broker who will raise the invoice for the wool
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation InvoicingOrganisation { get; set; }

        /// <summary>
        /// The broker that is responsible for releasing the wool out of the store
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation ReleasingOrganisation { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation SellingOrganisation { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        public WoolTypeGroup? WoolTypeGroup { get; set; }
        
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required Centre CentreCatalogue { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DeliveryBasis DeliveryBasis { get; set; }

        /// <summary>
        /// Inclusion of the Delivery Area Centre Code is Mandatory when the Post Sale Service Charge includes delivery to a nominated area and a “D” is included in the Delivery Basis Field.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(5)]
        public Centre? CentreDelivery { get; set; }

        /// <summary>
        /// This field is to be used when the PSC includes optional delivery to a second area.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(5)]
        public Centre? AlternateDelivery { get; set; }
    }
}
