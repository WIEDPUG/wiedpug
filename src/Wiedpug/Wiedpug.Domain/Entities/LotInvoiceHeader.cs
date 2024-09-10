using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Aggregates.LotPriceAndBuyersAggregate;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Wiedpug.Domain.Entities
{
    public class LotInvoiceHeader
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
        [MinLength(1)]
        [MaxLength(6)]
        public required string LotIdentity { get; set; }

        /// <summary>
        /// Number of bales
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public required int NumberOfBales { get; set; }

        /// <summary>
        /// Total weight of the wool. In transmissions from Test Houses, Gross 
        /// includes Regrab Sample Weight. In all other transmissions, Regrab 
        /// Sample Weight will have been subtracted from the Gross of a lot or a 
        /// group before the transmission. See the chapter ‘Business Rules’ for a 
        /// fuller explanation.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight Gross { get; set; }

        /// <summary>
        /// The weight of the bale packaging
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight Tare { get; set; }

        /// <summary>
        /// The weight of a regrab sample, a grab sample taken after the wool has been initially sampled and tested, is shown on the new certificate.
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; }

        /// <summary>
        /// The selling price per weight unit. Generally, cost per weight unit will be in Australian cents per kilogram.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required int CostPerWeightUnit { get; set; }

        /// <summary>
        /// Required decimal field for first cost with two digits precision.
        /// </summary>
        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency FirstCost { get; set; }

        /// <summary>
        /// Optional numeric field for clean weight.
        /// </summary>
        ///
        [MinLength(4)]
        [MaxLength(9)] 
        public Weight? CleanWeight { get; set; }

        /// <summary>
        /// Optional enum type for yield type.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(2)]
        public YieldType? YieldType { get; set; }

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
        public string? ClientCrossReference { get; set; }

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
        [MinLength(1)]
        [MaxLength(20)]
        public string? WoolDescription { get; set; }

        /// <summary>
        /// Required enum type for pack material.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required PackMaterial PackMaterial { get; set; }

        // LotInvoice extension

        /// <summary>
        /// Goods & Services Tax Amount applicable to First Cost
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? GstFirstCost { get; set; }

        /// <summary>
        /// Goods & Services Tax Amount applicable to Total Post Sale Charge
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? GstTotalPostSaleCharge { get; set; }

        /// <summary>
        /// Required decimal field for total post sale charge with two digits precision.
        /// </summary>
        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency TotalPostSaleCharge { get; set; }

        /// <summary>
        /// The total (extended) amount of Post Sale Charge Rebate for the Lot. This value is provided where a value in the Post Sale Charge Rebate field exists
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? TotalPostSaleChargeRebate { get; set; }

        /// <summary>
        /// The total (extended) GST amount payable on the Post Sale Charge Rebate for the Lot.
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? GstTotalPostSaleChargeRebate { get; set; }

    }
}
