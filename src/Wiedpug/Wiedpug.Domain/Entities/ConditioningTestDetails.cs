using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class ConditioningTestDetails
    {
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency Charge { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required string Laboratory { get; set; }

        [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required RetestFlag RetestFlag { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        /// <summary>
        /// Unit in Grams.
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? MassOfGlobalSample { get; set; }

        /// <summary>
        /// Unit in Grams.
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? SumOfODMasses { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight GainLossOfInvoiceMass { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public required double MoistureContent { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public required double Regain { get; set; }

        /// <summary>
        /// Unit in KG.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight NetWeightODOfConsignment { get; set; }

        [Required]
        [StringLength (2)]
        public required YieldType YieldType { get; set; }

        /// <summary>
        /// Unit in KG.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight OfficialRegain { get; set; }

        [Required]
        [StringLength (1)]
        public required InvoiceMassFlag InvoiceMassFlag { get; set; }

        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string DateIssued { get; set; }
    }
}
