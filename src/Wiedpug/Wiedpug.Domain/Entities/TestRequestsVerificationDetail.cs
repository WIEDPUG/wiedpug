using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Aggregates.TestRequestsVerificationAggregate;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class TestRequestsVerificationDetail
    {
        [Required]
        public required TestDataHeader TestDataHeader { get; set; }

        [Required]
        public required TestRequestVerification TestRequestVerification { get;set; }

        public ContractLimitRequirement?   ContractLimitRequirement { get; set; }

        public DarkAndMedullatedFibreRiskDetail? DarkAndMedullatedFibreRiskDetails { get; set; }

        public List<TestRequestsVerificationBale>? TestRequestsVerificationBales { get; set; }
    }
}
