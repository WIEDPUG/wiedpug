using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class GetTestCertificatesRequest
    {
        [Required]
        [StringLength(2)]
        public required CountryCode CountryOfOrigin { get; set; }

        [Required]
        [StringLength(5)]
        public required string DocumentOriginator { get; set; }

        [Required]
        [StringLength(5)]
        public required string CurrentTransmitter { get; set; }

        [Required]
        [StringLength(5)]
        public required string CurrentReceiver { get; set; }

        [Required]
        [StringLength(5)]
        public required string FinalReceiver { get; set; }

        [StringLength(9)]
        public SoftwareIdentifier? SoftwareIdentifier { get; set; }

        /// <summary>
        /// Australian Business Number
        /// </summary>
        [Required]
        [StringLength(11)]
        public required string ABN { get; set; }
    }
}
