﻿using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using System.Threading.Channels;
using Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate;
using Wiedpug.Domain.Aggregates.LotPriceAndBuyersAggregate;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Wiedpug.Domain.Entities
{
    public class LotHeader
    {
        /// <summary>
        /// This is a compound name for lot number and lot suffix, where the lot 
        /// number is 5 numeric characters and the lot suffix is 1 alphanumeric
        /// character.The suffix is used when a lot is broken up by the original lot
        /// number is retained; for example.If 2 bales of a 10-bale lot got wet and
        /// the 8 bales and the 2 bales are offered separately, one could have a
        /// suffix A and the other a suffix B.Where a suffix is not used, the lot
        /// number occupies the whole of the Lot Identity field and is right justified.
        ///
        /// From:
        ///
        /// The current value that the Lot Identity is to be changed from.
        /// 
        /// To:
        /// 
        /// The new value that the Lot Identity is to be changed to.
        /// </summary>
        [Required]
        public required LotIdentity LotIdentity { get; set; } // FIELD NUMBER 2 - Lot Identity - Start: 3, Size: 6, Data Type: AN, Justification: R, Requirement Designator: M

        [Required]
        public required NumberOfBales NumberOfBales { get; set; } // FIELD NUMBER 3 - Bales - Start: 9, Size: 4, Data Type: N, Justification: R, Requirement Designator: M

        /// <summary>
        /// Total weight of the wool. In transmissions from Test Houses, Gross 
        /// includes Regrab Sample Weight.In all other transmissions, Regrab
        /// Sample Weight will have been subtracted from the Gross of a lot or a
        /// group before the transmission.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight Gross { get; set; } // FIELD NUMBER 4 - Gross - Start: 13, Size: 6, Data Type: N, Justification: R, Requirement Designator: M

        /// <summary>
        /// The weight of the bale packaging
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight Tare { get; set; } // FIELD NUMBER 5 - Tare - Start: 19, Size: 4, Data Type: N, Justification: R, Requirement Designator: M

        /// <summary>
        /// The weight of a regrab sample, a grab sample taken after the wool has 
        /// been initially sampled and tested, is shown on the new certificate.
        /// </summary>
                [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; } // FIELD NUMBER 6 - Regrab Sample Weight - Start: 23, Size: 2, Data Type: N, Justification: R, Requirement Designator: C

        /// <summary>
        /// The page of the printed auction catalogue on which the lot details will appear
        /// </summary>
        [Range(-999,999)]
        public int? CataloguePageNumber { get; set; } // FIELD NUMBER 7 - Catalogue Page Number - Start: 25, Size: 3, Data Type: N, Justification: R, Requirement Designator: C

        /// <summary>
        /// A boolean value to indicate whether the lot is included for sale in the auction.
        /// 
        /// It is used in New Zealand only.
        /// 
        /// true: normal Lot.
        /// 
        /// false: not a normal Lot.
        /// 
        /// </summary>
        public bool? IsNoLot { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public SourceCode? SourceCode { get; set; } // FIELD NUMBER 9 - Source Code - Start: 29, Size: 1, Data Type: ID, Justification: F, Requirement Designator: O

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required UpdateType UpdateType { get; set; } // FIELD NUMBER 10 - Update Type - Start: 30, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        /// <summary>
        /// These are the symbols defined in the AWEX Wool Selling Rules, to be 
        /// printed in a sale catalogue against any appropriate lot.In a transmitted
        /// catalogue they are left justified with no space or punctuation marks
        /// between symbols where more than one symbol is used.If this field
        /// contains spaces it will indicate that there are no catalogue symbols for 
        /// that lot.
        /// 
        /// To obtain the current code list of values that may be used in this field
        /// please go to this URL: http://www.awex.com.au/standards/catalogue/.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(6)]
        public required string CatalogueSymbol { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required PackMaterial PackMaterial { get; set; } // FIELD NUMBER 12 - Pack Material - Start: 37, Size: 2, Data Type: ID, Justification: L, Requirement Designator: M

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required LotType LotType { get; set; } // FIELD NUMBER 13 - Lot Type - Start: 39, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        /// <summary>
        /// This is the Reweigh Gross Kg of the lightest bale in the lot.
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? LightestIndividualBaleWeight { get; set; } // FIELD NUMBER 14 - Lightest Individual Bale Weight - Start: 40, Size: 3, Data Type: N, Justification: R, Requirement Designator: C

        [MinLength(1)]
        [MaxLength(4)]
        public ReportingFlag? ReportingFlag { get; set; } // FIELD NUMBER 15 - Reporting Flag - Start: 43, Size: 1, Data Type: ID, Justification: F, Requirement Designator: C

        public int? FirstOfferSeason { get; set; } // FIELD NUMBER 16 - First Offer Season - Start: 44, Size: 2, Data Type: N, Justification: R, Requirement Designator: C

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
        [MinLength(1)]
        [MaxLength(4)]
        public SaleIdentity? FirstOfferSaleIdentity { get; set; } // FIELD NUMBER 17 - First Offer Sale Identity - Start: 46, Size: 4, Data Type: GR, Justification: -, Requirement Designator: C

        /// <summary>
        /// This is a compound name for lot number and lot suffix, where the lot number is 5 number characters and the lot suffix is 1 alphanumeric character.
        /// 
        /// The suffix is used when a lot is broken up but the original lot number is retained; for example, if 2 bales of a 10-bale lot got wet and the 8 bales the 2 bales are offered separately, one could have a suffix A and the other a suffix B.
        /// 
        /// Where a suffix is not used, the lot number occupies the whole of the Lot Identity field.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(6)]
        public LotIdentity? FirstOfferLotIdentity { get; set; } // FIELD NUMBER 18 - First Offer Lot Identity - Start: 50, Size: 6, Data Type: AN, Justification: R, Requirement Designator: C

        /// <summary>
        /// The selling price per weight unit. Generally, cost per weight unit will be in Australian cents per kilogram.
        /// </summary>
        public Currency? CostPerWeightUnit { get; set; } // FIELD NUMBER 19 - Cost per Weight Unit - Start: 56, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        /// <summary>
        /// Clean weight = Net Weight X Yield
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? CleanWeight { get; set; } // FIELD NUMBER 20 - Clean Weight - Start: 62, Size: 5, Data Type: N, Justification: R, Requirement Designator: O

        [MinLength(1)]
        [MaxLength(2)]
        public YieldType? YieldType { get; set; } // FIELD NUMBER 21 - Yield Type - Start: 67, Size: 2, Data Type: ID, Justification: R, Requirement Designator: O

        [MinLength(1)]
        [MaxLength(2)]
        public OfferType? OfferType { get; set; } // FIELD NUMBER 23 - Offer Type - Start: 70, Size: 2, Data Type: ID, Justification: R, Requirement Designator: O

        /// <summary>
        /// The identity given to the lot in the computer system by the owner of the wool.
        /// 
        /// Client’s Cross Reference is transmitted by the owner of the wool to a Test House when the owner either verifies a test request(in a type of
        /// TRV document) or requests the printing of a certificate(in a type TCR document). If it is included in the transmission to the Test House, the
        /// Test House will also include it in its transmission of the certificate.The owner of the wool will then be able to connect the transmitted certificate
        /// with the wool in its computer system.In a Test Request Verification document, the field must contain the weight note number of the lot.
        /// The value in this field is NOT printed on the certificate.It is the value in the Certificate Reference field that is printed on the certificate.
        /// </summary>
        [MinLength(1)]
        [MaxLength(8)]
        public string? ClientCrossReference { get; set; } // FIELD NUMBER 24 - Client Cross Reference - Start: 72, Size: 8, Data Type: AN, Justification: L, Requirement Designator: O

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required PackCondition PackCondition { get; set; } // FIELD NUMBER 25 - Pack Condition - Start: 80, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M


        // LotHeaderExension


        /// <summary>
        /// For Fibre Diameter Histogram Header and Test Request Verification this is the date core test was sampled or date combination/OML was requested.
        /// 
        /// For the Lot Header this is the date the core test was sampled, the last date of weighing for untested wool or the date the Combination/OML was requested.
        /// 
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
        public LiteralDate?  CoreTestSamplingDate { get; set; } // FIELD NUMBER 3 - Core Test Sampling Date - Start: 4, Size: 6, Data Type: DATE, Justification: F, Requirement Designator: C

        /// <summary>
        /// This field provides for additional comments relating to the information contained in the Wool Description field.
        /// </summary>
        [MinLength(1)]
        [MaxLength(14)]
        public string? WoolDescriptionComment { get; set; } // FIELD NUMBER 4 - Wool Description Comment - Start: 10, Size: 14, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// This field contains a description that is either an AWEX-ID description or another appraisal description.
        /// 
        /// Alternative valid appraisal descriptions include AWC type, Exporter type.
        /// 
        /// The AWEX-ID description must conform to the current AWEX-ID code standard.
        /// 
        /// If sending an AWC type, the first character of this field must be set to `W`, followed by the AWC Type, for all other non AWEX-ID typing descriptions the first character should be set to `P` followed by the type.If sending AWEX-ID the type starts from position one of the field (i.e.there are no leading characters). 
        /// 
        /// This field is to be always transmitted in upper case.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public required string WoolDescription { get; set; } // FIELD NUMBER 5 - Wool Description - Start: 24, Size: 20, Data Type: AN, Justification: L, Requirement Designator: M

        /// <summary>
        /// A boolean value to indicate whether the GST amount is applicable to invoice. 
        /// 
        /// true: applicable.
        /// 
        /// false: not applicable.
        /// </summary>
        public bool? IsGstApplicable { get; set; }

        [MinLength(3)]
        [MaxLength(6)]
        public Currency? BrokerReservePrice { get; set; } // FIELD NUMBER 7 - Broker Reserve Price - Start: 45, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        [MinLength(3)]
        [MaxLength(6)]
        public Currency? GrowerReservePrice { get; set; } // FIELD NUMBER 8 - Grower Reserve Price - Start: 51, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        [MinLength(3)]
        [MaxLength(6)]
        public Currency? OpeningPrice { get; set; } // FIELD NUMBER 9 - Opening Price - Start: 57, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        [MinLength(3)]
        [MaxLength(6)]
        public Currency? ValuationPrice { get; set; } // FIELD NUMBER 10 - Valuation Price - Start: 63, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        /// <summary>
        /// Audit code used for verifying if AWEX-ID was issued by AWEX.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(10)]
        public string? WoolDescriptionAuditCode { get; set; } // FIELD NUMBER 11 - Wool Description Audit Code - Start: 69, Size: 10, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// This is the total number of bales with a Reweigh Gross Kg over 204kg.
        /// </summary>
        [Range(-99,99)]
        public int? NumberOfOverweightBales { get; set; } // FIELD NUMBER 12 - Number of Overweight Bales - Start: 79, Size: 2, Data Type: N, Justification: R, Requirement Designator: C

    }
}
