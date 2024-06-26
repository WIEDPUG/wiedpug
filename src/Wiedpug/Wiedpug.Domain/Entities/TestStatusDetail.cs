using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class TestStatusDetail
    {
        /// <summary>
        /// Enum type for Certificate ID prefix.
        /// </summary>
        [Required]
        [StringLength(1)]
        public required CertificateIDPrefix CertificateIDPrefix { get; set; }

        /// <summary>
        /// Required generic string field for weight note.
        /// </summary>
        [Required]
        [StringLength(8)]
        public required string WeightNote { get; set; }

        /// <summary>
        /// Required numeric field for client code.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required string ClientCode { get; set; }

        /// <summary>
        /// Required numeric field for charge code.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required string ChargeCode { get; set; }

        /// <summary>
        /// Optional generic string field for L/S Sample ID.
        /// </summary>
        /// 
        [StringLength(7)]
        public string? LSSampleID { get; set; }

        /// <summary>
        /// Optional date field for when the core sample was received.
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [StringLength(10)]
        public string? CoreSampleReceived { get; set; }

        /// <summary>
        /// Optional date field for when the L/S sample was received.
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [StringLength(10)]
        public string? LSSampleReceived { get; set; }

        /// <summary>
        /// Optional date field for when the TRV matched.
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [StringLength(10)]
        public string? TRVMatched { get; set; }

        /// <summary>
        /// Optional date field for core sample check test.
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [StringLength(10)]
        public string? CoreSampleCheckTest { get; set; }

        /// <summary>
        /// Optional enum for L/S retuft required.
        /// </summary>
        /// 
        [StringLength(1)]
        public LsRetuftRequired? LsRetuftRequired { get; set; }

        /// <summary>
        /// Optional date field for when L/S retuft was received.
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [StringLength(10)]
        public string? LsRetuftReceived { get; set; }

        /// <summary>
        /// Optional enum for core test recore required.
        /// </summary>
        /// 
        [StringLength(1)]
        public CoreTestRecoreRequired? CoreTestRecoreRequired { get; set; }

        /// <summary>
        /// Optional date field for when the core test recore was received.
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [StringLength(10)]
        public string? CoreTestRecoreReceived { get; set; }
    }


}

