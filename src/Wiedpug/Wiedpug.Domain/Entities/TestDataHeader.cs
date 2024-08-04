using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class TestDataHeader
    {
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation Client { get; set; }

        [MinLength(1)]
        [MaxLength(2)]
        public int? Season { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        public SaleIdentity? SaleIdentity { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public Centre? CentreStorage { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(6)]
        public required string LotIdentityOrGroupName { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public WeightNote? WeightNote { get; set; }

        [MinLength(1)]
        [MaxLength(8)]
        public string? ClientsCrossReference { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public required int Bales { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight Gross { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight Tare { get; set; }

        [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; }

        [MinLength(1)]
        [MaxLength(2)]
        public MulesingStatus? MulesingStatus { get; set; }

        [MinLength(4)]
        [MaxLength(9)]
        public Weight? DeclaredGross { get; set; }

        [MinLength(4)]
        [MaxLength(9)]
        public Weight? DeclaredTare { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public LotType LotType { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        public Centre? CentreAuction { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public SourceCode? SourceCode { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public ReportingFlag? ReportingFlag { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public ScouredType? ScouredType { get; set; }

        /// <summary>
        /// A GST Amount with 2 digits after the decimal point
        /// </summary>
        [MinLength(6)]
        [MaxLength(15)]
        public Currency? GSTAmount { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the GST is aplicable. 
        /// true: applicable.
        /// false: not applicable.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsGSTApplicable { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the Company ABN is applicable to invoice. 
        /// true: applicable.
        /// false: not applicable.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsCompanyABNApplicable { get; set; }
    }
}
