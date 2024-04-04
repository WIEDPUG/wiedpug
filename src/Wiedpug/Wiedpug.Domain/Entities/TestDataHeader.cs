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
        public required Client Client { get; set; }
        public int? Season { get; set; }
        public SaleIdentity? SaleIdentity { get; set; }
        public Centre? CentreStorage { get; set; }
        public string? LotIdentity { get; set; }
        public string? GroupNumber { get; set; }
        public string? WeightNote { get; set; }
        public string? ClientsCrossReference { get; set; }
        [Required]
        public required int Bales { get; set; }
        [Required]
        public required int Gross { get; set; }
        [Required]
        public required int Tare { get; set; }
        public int RegrabSampleWeight { get; set; }
        [Required]
        public required WeightUnit WeightUnit { get; set; }
        public MulesingStatus? MulesingStatus { get; set; }
        public int? DeclaredGross { get; set; }
        public int? DeclaredTare { get; set; }
        public LotType LotType { get; set; }
        public Centre CentreAuction { get; set; }
        public SourceCode SourceCode { get; set; }
        [Required]
        public required ReportingFlag ReportingFlag { get; set; }
        public SourcedType ScouredType { get; set; }
        /// <summary>
        /// A GST Amount with 2 digits after the decimal point
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? GSTAmount { get; set; }
        /// <summary>
        /// A Flag to determine if GST apply to invoice
        /// </summary>
        [Required]
        public required Boolean IsGSTApplicable { get; set; }
        /// <summary>
        /// A Flag to determine if Compnay ABN apply to invoice
        /// </summary>
        [Required]
        public required Boolean IsCompanyABNApplicable { get; set; }
    }
}
