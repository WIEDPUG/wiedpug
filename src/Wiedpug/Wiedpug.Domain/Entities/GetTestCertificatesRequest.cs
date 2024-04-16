using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class GetTestCertificatesRequest
    {
        /// <summary>
        /// A code for the country in which the transmission was created.
        /// </summary>
        [Required]
        public required CountryCode CountryOfOrigin { get; set; }

        [Required]
        public required string DocumentOriginator { get; set; }

        [Required]
        public required string CurrentTransmitter { get; set; }

        [Required]
        public required string CurrentReceiver { get; set; }

        [Required]
        public required string FinalReceiver { get; set; }

        public SoftwareIdentifier? SoftwareIdentifier { get; set; }

        [Required]
        public required string Abn { get; set; }
    }
}
