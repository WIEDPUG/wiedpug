using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class TransmissionHeader
    {
        [Required]
        public RecordType RecordType { get; set; }

        /// <summary>
        /// Date value in ISO 8601 standard. e.g. 2024-03-21 (year-month-day)
        /// </summary>        
        [Required]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public string DateFormatLastRevised { get; set; }

        /// <summary>
        /// Date value in ISO 8601 standard. e.g. 2024-03-21 (year-month-day)
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public string DateTransmissionFileCreated { get; set; }

        /// <summary>
        /// A code for the country in which the transmission was created.
        /// </summary>
        [Required]        
        public CountryCode CountryOfOrigin { get; set; }

        [Required]
        public string DocumentOriginator { get; set; }

        [Required]
        public string CurrentTransmitter { get; set; }

        [Required]
        public string CurrentReceiver { get; set; }

        [Required]
        public string FinalReceiver { get; set; }

        [Required]
        public string AccessPassword { get; set; }

        [Required]
        public string AccessPasswordReplacement { get; set; }

        [Required]
        public TransmissionType TransmissionType { get; set; }

        [Required]
        public string VersionNumber { get; set; }

        [Required]
        public SoftwareIdentifier SoftwareIdentifier { get; set; }

        [Required]
        public string Abn { get; set; }

    }
}
