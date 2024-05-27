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
        [StringLength(10)]
        public required string DateFormatLastRevised { get; set; }

        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [StringLength(10)]
        public required string DateTransmissionFileCreated { get; set; }

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

        [Required]
        [StringLength(2)]
        public required TransmissionType TransmissionType { get; set; }

        /// <summary>
        /// Two digits. e.g. 99
        /// </summary>
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? VersionNumber { get; set; }

        [StringLength(9)]
        public SoftwareIdentifier? SoftwareIdentifier { get; set; }

        /// <summary>
        /// Australian Business Number, 11 digits string
        /// </summary>
        [Required]
        [StringLength(11)]
        [RegularExpression(RegexPattern.NUMBERS)]
        public required string ABN { get; set; }

    }
}
