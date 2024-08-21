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

        [MinLength(4)]
        [MaxLength(9)]
        public Weight? CoreSampleWeight { get; set; }

        /// <summary>
        /// For records Fibre Diameter Histogram Header and Test Request Verification this is the date core test was sampled or date combination/OML was requested.
        /// 
        /// For the Lot Header this is the date the core test was sampled, the last date of weighing for untested wool or the date the Combination/OML was requested.
        /// 
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
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
        /// 
        /// true: Update previous data.
        /// 
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
        /// A boolean value to indicate whether Yield And Laserscan Test is required.
        /// 
        /// true: Yield And Laserscan Test is required.
        /// 
        /// false: Yield And Laserscan Test is not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsYieldAndMicronTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Length And Strength Test is required.
        /// 
        /// true: Length And Strength Test is required.
        /// 
        /// false: Length And Strength Test is not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsLengthAndStrengthTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Length Only Test is required.
        /// 
        /// true: Length Only Test is required.
        /// 
        /// false: Length Only Test is not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsLengthOnlyTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Colour Test is required.
        /// 
        /// true: Colour Test is required.
        /// 
        /// false: Colour Test is not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsColourTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Laserscan Test is required.
        /// 
        /// true: Laserscan Test is required.
        /// 
        /// false: Laserscan Test is not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsLaserscanTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Airflow Test is required.
        /// 
        /// true: Airflow Test is required.
        /// 
        /// false: Airflow Test is not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsAirflowTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether OFDA Test is required.
        /// 
        /// true: OFDA Test is required.
        /// 
        /// false: OFDA Test is not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsOFDATestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Dark And Medullated Fibre Test is required.
        /// 
        /// true: Dark And Medullated Fibre Test is required.
        /// 
        /// false: Dark And Medullated Fibre Test is not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsDarkAndMedullatedFibreTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Pesticide Residue Test is required.
        /// 
        /// true: Pesticide Residue Test is required.
        /// 
        /// false: Pesticide Residue Test is not required.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsPesticideResidueTestRequired { get; set; }
    }

}
