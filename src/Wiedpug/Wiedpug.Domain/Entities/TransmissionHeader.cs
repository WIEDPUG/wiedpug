using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class TransmissionHeader
    {
        /// <summary>
        /// Date value in ISO 8601 standard. e.g. 2024-03-21 (year-month-day)
        /// </summary>        
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string DateFormatLastRevised { get; set; }

        /// <summary>
        /// Date value in ISO 8601 standard. e.g. 2024-03-21 (year-month-day)
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required string DateTransmissionFileCreated { get; set; }

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

        public string? AccessPassword { get; set; }

        public string? AccessPasswordReplacement { get; set; }

        public TransmissionType? TransmissionType { get; set; }       

        public int? VersionNumber { get; set; }

        public SoftwareIdentifier? SoftwareIdentifier { get; set; }

        [Required]
        public required string Abn { get; set; }

    }
}
