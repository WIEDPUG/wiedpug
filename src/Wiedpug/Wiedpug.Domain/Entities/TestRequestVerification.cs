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
        [MinLength(1)]
        [MaxLength(1)]
        public required Laboratory Laboratory { get; set; }

        /// <summary>
        /// Optional alphanumeric field for grower code.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(8)]
        public string? GrowerCode { get; set; }

        /// <summary>
        /// Optional alphanumeric field for grower name.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(30)]
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
        [MinLength(1)]
        [MaxLength(10)]
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
        /// True: Update previous data.
        /// False: Do not update previous data.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required bool UpdatePreviousData { get; set; }

        /// <summary>
        /// Required numeric field for hash total.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_8_DIGITS)]
        public required int HashTotal { get; set; }

        /// <summary>
        /// This field indicates whether Yield and Airflow Test is required until 30/06/2000.
        /// True: required.
        /// False: not required.
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public bool? IsYieldAndMicronTestRequired { get; set; }

        /// <summary>
        /// This field indicates whether Length And Strength Test is required.
        /// True: required.
        /// False: not required.
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public bool? IsLengthAndStrengthTestRequired { get; set; }

        /// <summary>
        /// This field indicates whether Length Only Test is required.
        /// True: required.
        /// False: not required.
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public bool? IsLengthOnlyTestRequired { get; set; }

        /// <summary>
        /// This field indicates whether Colour Test is required.
        /// True: required.
        /// False: not required.
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public bool? IsColourTestRequired { get; set; }

        /// <summary>
        /// This field indicates whether Laserscan Test is required.
        /// True: required.
        /// False: not required.
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public bool? IsLaserscanTestRequired { get; set; }

        /// <summary>
        /// This field indicates whether Airflow Test is required.
        /// True: required.
        /// False: not required.
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public bool? IsAirflowTestRequired { get; set; }

        /// <summary>
        /// This field indicates whether OFDA Test is required.
        /// True: required.
        /// False: not required.
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public bool? IsOFDATestRequired { get; set; }

        /// <summary>
        /// This field indicates whether Dark And Medullated Fibre Test is required.
        /// True: required.
        /// False: not required.
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public bool? IsDarkAndMedullatedFibreTestRequired { get; set; }

        /// <summary>
        /// This field indicates whether Pesticide Residue Test is required.
        /// True: required.
        /// False: not required.
        /// </summary>
        [MinLength(1)]
        [MaxLength(5)]
        public bool? IsPesticideResidueTestRequired { get; set; }
    }

}
