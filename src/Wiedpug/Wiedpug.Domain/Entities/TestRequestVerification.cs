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
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? CoreSampleWeight { get; set; }

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
        /// A boolean value to indicate whether data sent on a previous transmission is to be updated by data in the current transmission.
        /// true: Update previous data.
        /// false: Do not update previous data.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(5)]
        public required bool IsPreviousDataToBeUpdated { get; set; }

        /// <summary>
        /// Required numeric field for hash total.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_8_DIGITS)]
        public required int HashTotal { get; set; }

        /// <summary>
        /// A boolean value to indicates whether Yield and Airflow Test is required until 30/06/2000.
        /// true: required.
        /// false: not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsYieldAndMicronTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicates whether Length And Strength Test is required.
        /// true: required.
        /// false: not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsLengthAndStrengthTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicates whether Length Only Test is required.
        /// true: required.
        /// false: not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsLengthOnlyTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicates whether Colour Test is required.
        /// true: required.
        /// false: not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsColourTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicates whether Laserscan Test is required.
        /// true: required.
        /// false: not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsLaserscanTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicates whether Airflow Test is required.
        /// true: required.
        /// false: not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsAirflowTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicates whether OFDA Test is required.
        /// true: required.
        /// false: not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsOFDATestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicates whether Dark And Medullated Fibre Test is required.
        /// true: required.
        /// false: not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsDarkAndMedullatedFibreTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicates whether Pesticide Residue Test is required.
        /// true: required.
        /// false: not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsPesticideResidueTestRequired { get; set; }
    }

}
