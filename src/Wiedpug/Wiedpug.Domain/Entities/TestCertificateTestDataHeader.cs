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
    public class TestCertificateTestDataHeader
    {
        [Required]
        [StringLength(8)]
        public required Organisation Client { get; set; }

        [StringLength(2)]
        public int? Season { get; set; }

        [StringLength(4)]
        public SaleIdentity? SaleIdentity { get; set; }

        [StringLength(5)]
        public Centre? CentreStorage { get; set; }

        [Required]
        [StringLength(6)]

        public required LotIdentityOrGroupName LotIdentityOrGroupName { get; set; }

        [StringLength(8)]
        public string? WeightNote { get; set; }

        [StringLength(8)]
        public string? ClientsCrossReference { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public required int Bales { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required int Gross { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public required int Tare { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? RegrabSampleWeight { get; set; }

        [Required]
        [StringLength(1)]
        public required WeightUnit WeightUnit { get; set; }

        [StringLength(2)]
        public MulesingStatus? MulesingStatus { get; set; }

        [StringLength(6)]
        public int? DeclaredGross { get; set; }

        [StringLength(4)]
        public int? DeclaredTare { get; set; }

        [StringLength(1)]
        public LotType LotType { get; set; }

        [StringLength(5)]
        public Centre CentreAuction { get; set; }

        [StringLength(1)]
        public SourceCode SourceCode { get; set; }

        [Required]
        [StringLength(1)]
        public required ReportingFlag ReportingFlag { get; set; }

        [StringLength(1)]
        public ScouredType ScouredType { get; set; }
        /// <summary>
        /// A GST Amount with 2 digits after the decimal point
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_6_2)]
        public double? GSTAmount { get; set; }
        /// <summary>
        /// A Flag to determine if GST apply to invoice
        /// </summary>
        [Required]
        [StringLength(5)]
        public required bool IsGSTApplicable { get; set; }
        /// <summary>
        /// A Flag to determine if Compnay ABN apply to invoice
        /// </summary>
        [Required]
        [StringLength(5)]
        public required bool IsCompanyABNApplicable { get; set; }
    }
}
