using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class TransmissionHeader
    {
        /// <summary>
        /// Date value in ISO standard. e.g. 240321 (YYMMDD)
        /// </summary>        
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(Regex.DATE)]
        public required string DateFormatLastRevised { get; set; }

        /// <summary>
        /// Date value in ISO standard. e.g. 240321 (YYMMDD)
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(Regex.DATE)]
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

        public SoftwareIdentifier? SoftwareIdentifier { get; set; }

        [Required]
        [StringLength(11)]
        [RegularExpression(Regex.NUMBERS)]
        public required string Abn { get; set; }

    }
}
