using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class LotHeaderExtension
    {
        /// <summary>
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21.
        /// For records 31 and 55 this is the date core test was sampled or date combination/OML was requested. 
        /// For the 21A record this is the date the core test was sampled, the last date of weighing for untested wool or the date the Combination/OML was requested.
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? CoreTestSamplingDate { get; set; } // FIELD NUMBER 3 - Core Test Sampling Date - Start: 4, Size: 6, Data Type: DATE, Justification: F, Requirement Designator: C

        /// <summary>
        /// This field provides for additional comments relating to the information contained in the Wool Description field.
        /// </summary>
        [MinLength(1)]
        [MaxLength(14)]
        public string? WoolDescriptionComment { get; set; } // FIELD NUMBER 4 - Wool Description Comment - Start: 10, Size: 14, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// This field contains a description that is either an AWEX-ID description or another appraisal description.
        /// Alternative valid appraisal descriptions include AWC type, Exporter type. 
        /// The AWEX-ID description must conform to the current AWEX-ID code standard.
        /// If sending an AWC type, the first character of this field must be set to `W`, followed by the AWC Type, for all other non AWEX-ID typing descriptions the first character should be set to `P` followed by the type.If sending AWEX-ID the type starts from position one of the field (i.e.there are no leading characters). 
        /// This field is to be always transmitted in upper case.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public required string WoolDescription { get; set; } // FIELD NUMBER 5 - Wool Description - Start: 24, Size: 20, Data Type: AN, Justification: L, Requirement Designator: M

        /// <summary>
        /// A boolean value to indicate whether the GST amount is applicable to invoice. 
        /// true: applicable.
        /// false: not applicable.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsGstTaxInvoiceApplicable { get; set; }

        [MinLength(3)]
        [MaxLength(6)]
        public PriceCurrency? BrokerReservePrice { get; set; } // FIELD NUMBER 7 - Broker Reserve Price - Start: 45, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        [MinLength(3)]
        [MaxLength(6)]
        public PriceCurrency? GrowerReservePrice { get; set; } // FIELD NUMBER 8 - Grower Reserve Price - Start: 51, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        [MinLength(3)]
        [MaxLength(6)]
        public PriceCurrency? OpeningPrice { get; set; } // FIELD NUMBER 9 - Opening Price - Start: 57, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

        [MinLength(3)]
        [MaxLength(6)]
        public PriceCurrency? ValuationPrice { get; set; } // FIELD NUMBER 10 - Valuation Price - Start: 63, Size: 6, Data Type: N, Justification: R, Requirement Designator: O

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
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? NumberOfOverweightBales { get; set; } // FIELD NUMBER 12 - Number of Overweight Bales - Start: 79, Size: 2, Data Type: N, Justification: R, Requirement Designator: C
    }
}
