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
        [MinLength(1)]
        [MaxLength(1)]
        public required CertificateIDPrefix CertificateIDPrefix { get; set; }

        /// <summary>
        /// Required generic string field for weight note.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required WeightNote WeightNote { get; set; }

        /// <summary>
        /// Required numeric field for client code.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required int ClientCode { get; set; }

        /// <summary>
        /// Required numeric field for charge code.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        public required int ChargeCode { get; set; }

        /// <summary>
        /// Optional generic string field for L/S Sample ID.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(7)]
        public LsSampleId? LsSampleId { get; set; }

        /// <summary>
        /// Optional date field for when the core sample was received.
        ///
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD).  
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? CoreSampleReceived { get; set; }

        /// <summary>
        /// Optional date field for when the L/S sample was received.
        ///
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD).  
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? LSSampleReceived { get; set; }

        /// <summary>
        /// Optional date field for when the TRV matched.
        ///
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD).  
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? TRVMatched { get; set; }

        /// <summary>
        /// Optional date field for core sample check test.
        ///
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD).  
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? CoreSampleCheckTest { get; set; }

        /// <summary>
        /// Optional enum for L/S retuft required.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(1)]
        public LsRetuftRequired? LsRetuftRequired { get; set; }

        /// <summary>
        /// Optional date field for when L/S retuft was received.
        ///
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD).  
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? LsRetuftReceived { get; set; }

        /// <summary>
        /// Optional enum for core test recore required.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(1)]
        public CoreTestRecoreRequired? CoreTestRecoreRequired { get; set; }

        /// <summary>
        /// Optional date field for when the core test recore was received.
        ///
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD).  
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public string? CoreTestRecoreReceived { get; set; }
    }


}

