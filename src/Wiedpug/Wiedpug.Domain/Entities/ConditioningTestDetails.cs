using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class ConditioningTestDetails
    {
        [Required]
        public required string CertificateIdentity { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double Charge { get; set; }

        [Required]
        public required string Laboratory { get; set; }

        public int? RegrabSampleWeight { get; set; }

        [Required]
        public required RetestFlag RetestFlag { get; set; }

        [Required]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_ONE_DIGITS)]
        public double? MassOfGlobalSample { get; set; }

        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public double? SumOfODMasses { get; set; }

        [Required]
        public required int GainLossOfInvoiceMass { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double MoistureContent { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double Regain { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_SIX_DIGITS)]
        public required double NetWeightODOfConsignment { get; set; }

        [Required]
        public required YieldType YieldType { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_SIX_DIGITS)]
        public required double OfficialRegain { get; set; }

        [Required]
        public required InvoiceMassFlag InvoiceMassFlag { get; set; }

        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string DateIssued { get; set; }
    }
}
