using System.ComponentModel.DataAnnotations;
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

        public ContractLimitRequirements?   ContractLimitRequirements { get; set; }

        public DarkAndMedullatedFibreRiskDetails? DarkAndMedullatedFibreRiskDetails { get; set; }

        public List<Bale>? Bales { get; set; }
    }
}
