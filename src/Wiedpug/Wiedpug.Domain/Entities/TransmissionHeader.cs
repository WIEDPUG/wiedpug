using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class TransmissionHeader
    {
        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>        
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string DateFormatLastRevised { get; set; }

        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string DateTransmissionFileCreated { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required CountryCode CountryOfOrigin { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation DocumentOriginator { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation CurrentReceiver { get; set; }

        /// <summary>
        /// Two digits. e.g. 99
        /// </summary>
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? VersionNumber { get; set; }

        [MinLength(1)]
        [MaxLength(9)]
        public SoftwareIdentifier? SoftwareIdentifier { get; set; }

        /// <summary>
        /// Australian Business Number, 11 digits string
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        [RegularExpression(RegexPattern.NUMBERS)]
        public required string ABN { get; set; }

    }
}
