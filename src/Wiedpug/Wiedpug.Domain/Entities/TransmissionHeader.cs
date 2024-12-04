using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class TransmissionHeader
    {         
        [Required]
        public required LiteralDate DateFormatLastRevised { get; set; }

        [Required]
        public required LiteralDate DateTransmissionFileCreated { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required CountryCode CountryOfOrigin { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation DocumentOriginator { get; set; }

        /// <summary>
        /// The code for the organisation that will receive the document at the end 
        /// of the current transmission.Where a document is transferred from one
        /// organisation to another through an intermediary, the code for the
        /// current receiver will vary from leg to leg of the journey.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation CurrentReceiver { get; set; }

        /// <summary>
        /// The full version number of API that the transmission relates to.
        /// 
        /// It uses Semantic Versioning. https://semver.org/
        /// 
        /// The format is MAJOR.MINOR.PATCH. e.g. 1.10.2
        /// </summary>
        public string? VersionNumber { get; set; }

        [MinLength(1)]
        [MaxLength(9)]
        public SoftwareIdentifier? SoftwareIdentifier { get; set; }

        /// <summary>
        /// Australian Business Number, 11 digits
        /// </summary>
        [Required]
        [Range(10000000000,99999999999)]
        public required long Abn { get; set; }
    }
}
