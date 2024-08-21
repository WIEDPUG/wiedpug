using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.TestRequestsVerificationAggregate
{
    public class TestRequestsVerificationBale
    {
        [Required]
        public required BaleHeader BaleHeader { get; set; }

        public List<BaleDetail>? BaleDetails { get; set; }

        /// <summary>
        /// Property Identification Code - the property code to identify the source of the wool.
        /// 
        /// This field is not used in New Zealand transmission.
        /// 
        /// For TRV only.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(8)]
        public List<string>? PropertyIdentificationCodes { get; set; }

    }
}
