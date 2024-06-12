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
        [StringLength(8)]
        public required Organisation DocumentOriginator { get; set; }

        [Required]
        [StringLength(8)]
        public required Organisation CurrentTransmitter { get; set; }

        [Required]
        [StringLength(8)]
        public required Organisation CurrentReceiver { get; set; }

        [Required]
        [StringLength(8)]
        public required Organisation FinalReceiver { get; set; }

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
