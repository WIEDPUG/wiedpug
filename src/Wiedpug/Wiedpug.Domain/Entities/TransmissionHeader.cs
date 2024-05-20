using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class TransmissionHeader
    {
        /// <summary>
        /// Date value in ISO standard. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>        
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        [StringLength(10)]
        public required string DateFormatLastRevised { get; set; }

        /// <summary>
        /// Date value in ISO standard. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
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

        [StringLength(10)]
        public string? AccessPassword { get; set; }

        [StringLength(10)]
        public string? AccessPasswordReplacement { get; set; }

        [StringLength(2)]
        public TransmissionType? TransmissionType { get; set; }

        [StringLength(2)]
        [RegularExpression(Regex.NUMBERS)]
        public string? VersionNumber { get; set; }

        [StringLength(9)]
        public SoftwareIdentifier? SoftwareIdentifier { get; set; }

        /// <summary>
        /// Australian Business Number
        /// </summary>
        [Required]
        [StringLength(11)]
        [RegularExpression(Regex.NUMBERS)]
        public required string ABN { get; set; }

    }
}
