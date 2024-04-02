using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using Wiedpug.Domain.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Wiedpug.Domain.Entities
{
    public class LotHeader
    {
        [Required]
        public required string LotIdentity { get; set; } // FIELD NUMBER 2 - Lot Identity - Start: 3, Size: 6, Data Type: AN, Justification: R, Requirement Designator: M

        [Required]
        public required int Bales { get; set; } // FIELD NUMBER 3 - Bales - Start: 9, Size: 4, Data Type: N, Justification: R, Requirement Designator: M

        [Required]
        public required int Gross { get; set; } // FIELD NUMBER 4 - Gross - Start: 13, Size: 6, Data Type: N, Justification: R, Requirement Designator: M

        [Required]
        public required int Tare { get; set; } // FIELD NUMBER 5 - Tare - Start: 19, Size: 4, Data Type: N, Justification: R, Requirement Designator: M

        public int? RegrabSampleWeight { get; set; } // FIELD NUMBER 6 - Regrab Sample Weight - Start: 23, Size: 2, Data Type: N, Justification: R, Requirement Designator: C

        public int? CataloguePageNumber { get; set; } // FIELD NUMBER 7 - Catalogue Page Number - Start: 25, Size: 3, Data Type: N, Justification: R, Requirement Designator: C

        /// <summary>
        /// A flag used to indicate whether or not the lot is included for sale in the auction.
        /// It is used in New Zealand only.
        /// `true` = Normal Lot, `false` = No Lot
        /// </summary>
        public bool? NoLotFlag { get; set; } // FIELD NUMBER 8 - No Lot Flag - Start: 28, Size: 1, Data Type: ID, Justification: F, Requirement Designator: C

        public SourceCode? SourceCode { get; set; } // FIELD NUMBER 9 - Source Code - Start: 29, Size: 1, Data Type: ID, Justification: F, Requirement Designator: O

        [Required]
        public required UpdateType UpdateType { get; set; } // FIELD NUMBER 10 - Update Type - Start: 30, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        [Required]
        public required CatalogueSymbol CatalogueSymbols { get; set; } // FIELD NUMBER 11 - Catalogue Symbols - Start: 31, Size: 6, Data Type: ID, Justification: L, Requirement Designator: M

        [Required]
        public required PackMaterial PackMaterial { get; set; } // FIELD NUMBER 12 - Pack Material - Start: 37, Size: 2, Data Type: ID, Justification: L, Requirement Designator: M

        [Required]
        public required LotType LotType { get; set; } // FIELD NUMBER 13 - Lot Type - Start: 39, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        /// <summary>
        /// This is the Reweigh Gross Kg of the lightest bale in the lot.
        /// </summary>
        public int? LightestIndividualBaleWeight { get; set; } // FIELD NUMBER 14 - Lightest Individual Bale Weight - Start: 40, Size: 3, Data Type: N, Justification: R, Requirement Designator: C

        public ReportingFlag? ReportingFlag { get; set; } // FIELD NUMBER 15 - Reporting Flag - Start: 43, Size: 1, Data Type: ID, Justification: F, Requirement Designator: C
        
        public int? FirstOfferSeason { get; set; } // FIELD NUMBER 16 - First Offer Season - Start: 44, Size: 2, Data Type: N, Justification: R, Requirement Designator: C

        public string? FirstOfferSaleIdentity { get; set; } // FIELD NUMBER 17 - First Offer Sale Identity - Start: 46, Size: 4, Data Type: GR, Justification: -, Requirement Designator: C

        /// <summary>
        /// This is a compound name for lot number and lot suffix, where the lot number is 5 number characters and the lot suffix is 1 alphanumeric character.
        /// The suffix is used when a lot is broken up but the original lot number is retained; for example, if 2 bales of a 10-bale lot got wet and the 8 bales the 2 bales are offered separately, one could have a suffix A and the other a suffix B. 
        /// Where a suffix is not used, the lot number occupies the whole of the Lot Identity field.
        /// </summary>
        public string? FirstOfferLotIdentity { get; set; } // FIELD NUMBER 18 - First Offer Lot Identity - Start: 50, Size: 6, Data Type: AN, Justification: R, Requirement Designator: C

        public int? CostPerWeightUnit { get; set; } // FIELD NUMBER 19 - Cost per Weight Unit - Start: 56, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        public int? CleanWeight { get; set; } // FIELD NUMBER 20 - Clean Weight - Start: 62, Size: 5, Data Type: N, Justification: R, Requirement Designator: O

        public YieldType? YieldType { get; set; } // FIELD NUMBER 21 - Yield Type - Start: 67, Size: 2, Data Type: ID, Justification: R, Requirement Designator: O

        public WeightUnit? WeightUnit { get; set; } // FIELD NUMBER 22 - Weight Unit - Start: 69, Size: 1, Data Type: ID, Justification: F, Requirement Designator: O

        public OfferType? OfferType { get; set; } // FIELD NUMBER 23 - Offer Type - Start: 70, Size: 2, Data Type: ID, Justification: R, Requirement Designator: O

        public string? ClientCrossReference { get; set; } // FIELD NUMBER 24 - Client Cross Reference - Start: 72, Size: 8, Data Type: AN, Justification: L, Requirement Designator: O

        [Required]
        public required PackCondition PackCondition { get; set; } // FIELD NUMBER 25 - Pack Condition - Start: 80, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M
    }
}
