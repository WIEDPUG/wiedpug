using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class TestRequestVerification
    {
        /// <summary>
        /// Enum type for laboratory identification.
        /// </summary>
        [Required]
        [StringLength(1)]
        public required Laboratory Laboratory { get; set; }

        /// <summary>
        /// Optional alphanumeric field for grower code.
        /// </summary>
        /// 
        [StringLength(8)]
        public string? GrowerCode { get; set; }

        /// <summary>
        /// Optional alphanumeric field for grower name.
        /// </summary>
        /// 
        [StringLength(30)]
        public string? GrowerName { get; set; }

        /// <summary>
        /// Optional numeric field for core sample weight.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? CoreSampleWeight { get; set; }

        /// <summary>
        /// Optional date field for core test sampling.
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [StringLength(10)]
        public string? CoreTestSamplingDate { get; set; }

        /// <summary>
        /// Optional numeric field for cores per bale.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? CoresPerBale { get; set; }

        /// <summary>
        /// Optional numeric field for grabs per bale.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? GrabsPerBale { get; set; }

        /// <summary>
        /// This field indicates whether data sent on a previous transmission is to be updated by data in the current transmission.
        /// </summary>
        [Required]
        [StringLength(5)]
        public required bool UpdatePreviousData { get; set; }

        /// <summary>
        /// Required numeric field for hash total.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_8_DIGITS)]
        public required int HashTotal { get; set; }

        [StringLength(5)]
        public bool? IsYieldAndMicronTestRequired { get; set; }

        [StringLength(5)]
        public bool? IsLengthAndStrengthTestRequired { get; set; }

        [StringLength(5)]
        public bool? IsLengthOnlyTestRequired { get; set; }

        [StringLength(5)]
        public bool? IsColourTestRequired { get; set; }

        [StringLength(5)]
        public bool? IsLaserscanTestRequired { get; set; }

        [StringLength(5)]
        public bool? IsAirflowTestRequired { get; set; }

        [StringLength(5)]
        public bool? IsOFDATestRequired { get; set; }

        [StringLength(5)]
        public bool? IsDarkAndMedullatedFibreTestRequired { get; set; }

        [StringLength(5)]
        public bool? IsPesticideResidueTestRequired { get; set; }
    }

}
