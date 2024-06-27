using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;
using static System.Collections.Specialized.BitVector32;

namespace Wiedpug.Domain.Entities
{
    public class LotPriceAndBuyerWoolSaleHeaderLots
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
        [StringLength(5)]
        public required Centre CentreStorage { get; set; }

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
        
        [Required]
        [StringLength(4)]
        public required CatalogueSection CatalogueSection { get; set; }

        /// <summary>
        /// The code for the broker who will raise the invoice for the wool
        /// </summary>
        [Required]
        [StringLength(8)]
        public required Organisation InvoicingOrganisation { get; set; }

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
        [StringLength(8)]
        public required Organisation ReleasingOrganisation { get; set; }

        [Required]
        [StringLength(8)]
        public required Organisation SellingOrganisation { get; set; }

        [Required]
        [StringLength(4)]
        public required WoolTypeGroup WoolTypeGroup { get; set; }
        
        [Required]
        [StringLength(6)]
        public required Centre CentreCatalogue { get; set; }

    }
}
