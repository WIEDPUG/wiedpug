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
        public required Laboratory Laboratory { get; set; }

        /// <summary>
        /// Optional alphanumeric field for grower code.
        /// </summary>
        public string? GrowerCode { get; set; }

        /// <summary>
        /// Optional alphanumeric field for grower name.
        /// </summary>
        public string? GrowerName { get; set; }

        /// <summary>
        /// Optional numeric field for core sample weight.
        /// </summary>
        public int? CoreSampleWeight { get; set; }

        /// <summary>
        /// Optional date field for core test sampling.
        /// </summary>
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public string? CoreTestSamplingDate { get; set; }

        /// <summary>
        /// Optional numeric field for cores per bale.
        /// </summary>
        public int? CoresPerBale { get; set; }

        /// <summary>
        /// Optional numeric field for grabs per bale.
        /// </summary>
        public int? GrabsPerBale { get; set; }

        /// <summary>
        /// This field indicates whether data sent on a previous transmission is to be updated by data in the current transmission.
        /// </summary>
        [Required]
        public required bool UpdatePreviousData { get; set; }

        /// <summary>
        /// Required numeric field for hash total.
        /// </summary>
        [Required]
        public required int HashTotal { get; set; }

        public bool? IsYieldAndMicronTestRequired { get; set; }
        public bool? IsLengthAndStrengthTestRequired { get; set; }
        public bool? IsLengthOnlyTestRequired { get; set; }
        public bool? IsColourTestRequired { get; set; }
        public bool? IsLaserscanTestRequired { get; set; }
        public bool? IsAirflowTestRequired { get; set; }
        public bool? IsOFDATestRequired { get; set; }
        public bool? IsDarkAndMedullatedFibreTestRequired { get; set; }
        public bool? IsPesticideResidueTestRequired { get; set; }
    }

}
