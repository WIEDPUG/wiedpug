using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Wiedpug.Domain.Entities
{
    public class LotHeader
    {
        [Required]
        [StringLength(6)]
        public required string LotIdentity { get; set; } // FIELD NUMBER 2 - Lot Identity - Start: 3, Size: 6, Data Type: AN, Justification: R, Requirement Designator: M

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public required int Bales { get; set; } // FIELD NUMBER 3 - Bales - Start: 9, Size: 4, Data Type: N, Justification: R, Requirement Designator: M

        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required int Gross { get; set; } // FIELD NUMBER 4 - Gross - Start: 13, Size: 6, Data Type: N, Justification: R, Requirement Designator: M

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public required int Tare { get; set; } // FIELD NUMBER 5 - Tare - Start: 19, Size: 4, Data Type: N, Justification: R, Requirement Designator: M

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? RegrabSampleWeight { get; set; } // FIELD NUMBER 6 - Regrab Sample Weight - Start: 23, Size: 2, Data Type: N, Justification: R, Requirement Designator: C

        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? CataloguePageNumber { get; set; } // FIELD NUMBER 7 - Catalogue Page Number - Start: 25, Size: 3, Data Type: N, Justification: R, Requirement Designator: C

        /// <summary>
        /// A flag used to indicate whether or not the lot is included for sale in the auction.
        /// It is used in New Zealand only.
        /// `true` = Normal Lot, `false` = No Lot
        /// </summary>
        [StringLength(5)]
        public bool? IsNoLot { get; set; } // FIELD NUMBER 8 - No Lot Flag - Start: 28, Size: 1, Data Type: ID, Justification: F, Requirement Designator: C

        [StringLength(1)]
        public SourceCode? SourceCode { get; set; } // FIELD NUMBER 9 - Source Code - Start: 29, Size: 1, Data Type: ID, Justification: F, Requirement Designator: O

        [Required]
        [StringLength(1)]
        public required UpdateType UpdateType { get; set; } // FIELD NUMBER 10 - Update Type - Start: 30, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        [Required]
        [StringLength(2)]
        public required PackMaterial PackMaterial { get; set; } // FIELD NUMBER 12 - Pack Material - Start: 37, Size: 2, Data Type: ID, Justification: L, Requirement Designator: M

        [Required]
        [StringLength(1)]
        public required LotType LotType { get; set; } // FIELD NUMBER 13 - Lot Type - Start: 39, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        /// <summary>
        /// This is the Reweigh Gross Kg of the lightest bale in the lot.
        /// </summary>
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        public int? LightestIndividualBaleWeight { get; set; } // FIELD NUMBER 14 - Lightest Individual Bale Weight - Start: 40, Size: 3, Data Type: N, Justification: R, Requirement Designator: C

        [StringLength(4)]
        public ReportingFlag? ReportingFlag { get; set; } // FIELD NUMBER 15 - Reporting Flag - Start: 43, Size: 1, Data Type: ID, Justification: F, Requirement Designator: C

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? FirstOfferSeason { get; set; } // FIELD NUMBER 16 - First Offer Season - Start: 44, Size: 2, Data Type: N, Justification: R, Requirement Designator: C

        [StringLength(4)]
        public string? FirstOfferSaleIdentity { get; set; } // FIELD NUMBER 17 - First Offer Sale Identity - Start: 46, Size: 4, Data Type: GR, Justification: -, Requirement Designator: C

        /// <summary>
        /// This is a compound name for lot number and lot suffix, where the lot number is 5 number characters and the lot suffix is 1 alphanumeric character.
        /// The suffix is used when a lot is broken up but the original lot number is retained; for example, if 2 bales of a 10-bale lot got wet and the 8 bales the 2 bales are offered separately, one could have a suffix A and the other a suffix B. 
        /// Where a suffix is not used, the lot number occupies the whole of the Lot Identity field.
        /// </summary>
        /// 
        [StringLength(6)]
        public string? FirstOfferLotIdentity { get; set; } // FIELD NUMBER 18 - First Offer Lot Identity - Start: 50, Size: 6, Data Type: AN, Justification: R, Requirement Designator: C

        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public int? CostPerWeightUnit { get; set; } // FIELD NUMBER 19 - Cost per Weight Unit - Start: 56, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        [RegularExpression(RegexPattern.NUMBER_5_DIGITS)]
        public int? CleanWeight { get; set; } // FIELD NUMBER 20 - Clean Weight - Start: 62, Size: 5, Data Type: N, Justification: R, Requirement Designator: O

        [StringLength(2)]
        public YieldType? YieldType { get; set; } // FIELD NUMBER 21 - Yield Type - Start: 67, Size: 2, Data Type: ID, Justification: R, Requirement Designator: O

        [StringLength(1)]
        public WeightUnit? WeightUnit { get; set; } // FIELD NUMBER 22 - Weight Unit - Start: 69, Size: 1, Data Type: ID, Justification: F, Requirement Designator: O

        [StringLength(2)]
        public OfferType? OfferType { get; set; } // FIELD NUMBER 23 - Offer Type - Start: 70, Size: 2, Data Type: ID, Justification: R, Requirement Designator: O

        [StringLength(8)]
        public string? ClientCrossReference { get; set; } // FIELD NUMBER 24 - Client Cross Reference - Start: 72, Size: 8, Data Type: AN, Justification: L, Requirement Designator: O

        [Required]
        [StringLength(1)]
        public required PackCondition PackCondition { get; set; } // FIELD NUMBER 25 - Pack Condition - Start: 80, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M


        // LotHeaderExension


        /// <summary>
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21.
        /// For records 31 and 55 this is the date core test was sampled or date combination/OML was requested. 
        /// For the 21A record this is the date the core test was sampled, the last date of weighing for untested wool or the date the Combination/OML was requested.
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [StringLength(10)]
        public string? CoreTestSamplingDate { get; set; } // FIELD NUMBER 3 - Core Test Sampling Date - Start: 4, Size: 6, Data Type: DATE, Justification: F, Requirement Designator: C

        /// <summary>
        /// This field provides for additional comments relating to the information contained in the Wool Description field.
        /// </summary>
        [StringLength(14)]
        public string? WoolDescriptionComment { get; set; } // FIELD NUMBER 4 - Wool Description Comment - Start: 10, Size: 14, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// This field contains a description that is either an AWEX-ID description or another appraisal description.
        /// Alternative valid appraisal descriptions include AWC type, Exporter type. 
        /// The AWEX-ID description must conform to the current AWEX-ID code standard.
        /// If sending an AWC type, the first character of this field must be set to `W`, followed by the AWC Type, for all other non AWEX-ID typing descriptions the first character should be set to `P` followed by the type.If sending AWEX-ID the type starts from position one of the field (i.e.there are no leading characters). 
        /// This field is to be always transmitted in upper case.
        /// </summary>
        [Required]
        [StringLength(20)]
        public required string WoolDescription { get; set; } // FIELD NUMBER 5 - Wool Description - Start: 24, Size: 20, Data Type: AN, Justification: L, Requirement Designator: M

        /// <summary>
        /// `true` = GST amount is applicable to invoice. `false` = GST amount is not applicable to invoice.
        /// </summary>
        /// 
        [StringLength(5)]
        public bool? GstTaxInvoiceFlag { get; set; } // FIELD NUMBER 6 - GST Tax Invoice Flag - Start: 44, Size: 1, Data Type: ID, Justification: F, Requirement Designator: O

        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public int? BrokerReservePrice { get; set; } // FIELD NUMBER 7 - Broker Reserve Price - Start: 45, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public int? GrowerReservePrice { get; set; } // FIELD NUMBER 8 - Grower Reserve Price - Start: 51, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public int? OpeningPrice { get; set; } // FIELD NUMBER 9 - Opening Price - Start: 57, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public int? ValuationPrice { get; set; } // FIELD NUMBER 10 - Valuation Price - Start: 63, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        /// <summary>
        /// Audit code used for verifying if AWEX-ID was issued by AWEX.
        /// </summary>
        /// 
        [StringLength(10)]
        public string? WoolDescriptionAuditCode { get; set; } // FIELD NUMBER 11 - Wool Description Audit Code - Start: 69, Size: 10, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// This is the total number of bales with a Reweigh Gross Kg over 204kg.
        /// </summary>
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? NumberOfOverweightBales { get; set; } // FIELD NUMBER 12 - Number of Overweight Bales - Start: 79, Size: 2, Data Type: N, Justification: R, Requirement Designator: C

    }
}
