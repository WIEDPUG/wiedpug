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
        /// The name of the grower of the wool
        /// </summary>
        [MinLength(1)]
        [MaxLength(30)]
        public string? GrowerName { get; set; }

        /// <summary>
        /// The weight of the initial core sample
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? CoreSampleWeight { get; set; }

        /// <summary>
        /// For Fibre Diameter Histogram Header and Test Request Verification this is the date core test was sampled or date combination/OML was requested.
        /// 
        /// For the Lot Header this is the date the core test was sampled, the last date of weighing for untested wool or the date the Combination/OML was requested.
        /// </summary>
        public LiteralDate?  CoreTestSamplingDate { get; set; }

        /// <summary>
        /// Number of core samples taken from the bale.
        /// </summary>
        [Range(-99,99)]
        public int? CoresPerBale { get; set; }

        /// <summary>
        /// Number of grab samples taken from each bale
        /// </summary>
        [Range(-99,99)]
        public int? GrabsPerBale { get; set; }

        /// <summary>
        /// A boolean value to indicate whether data sent on a previous transmission is to be updated by data in the current transmission.
        /// 
        /// true: Update previous data.
        /// 
        /// false: Do not update previous data.
        /// </summary>
        [Required]

        public required bool IsPreviousDataToBeUpdated { get; set; }

        /// <summary>
        /// Required numeric field for hash total.
        /// </summary>
        [Required]
        [Range(-99999999,99999999)]
        public required int HashTotal { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Yield And Laserscan Test is required.
        /// 
        /// true: Yield And Laserscan Test is required.
        /// 
        /// false: Yield And Laserscan Test is not required.
        /// </summary>

        public bool? IsYieldAndMicronTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Length And Strength Test is required.
        /// 
        /// true: Length And Strength Test is required.
        /// 
        /// false: Length And Strength Test is not required.
        /// </summary>

        public bool? IsLengthAndStrengthTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Length Only Test is required.
        /// 
        /// true: Length Only Test is required.
        /// 
        /// false: Length Only Test is not required.
        /// </summary>

        public bool? IsLengthOnlyTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Colour Test is required.
        /// 
        /// true: Colour Test is required.
        /// 
        /// false: Colour Test is not required.
        /// </summary>

        public bool? IsColourTestRequired { get; set; }

        public LaserscanTestRequired? LaserscanTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Airflow Test is required.
        /// 
        /// true: Airflow Test is required.
        /// 
        /// false: Airflow Test is not required.
        /// </summary>

        public bool? IsAirflowTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether OFDA Test is required.
        /// 
        /// true: OFDA Test is required.
        /// 
        /// false: OFDA Test is not required.
        /// </summary>

        public bool? IsOfdaTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Dark And Medullated Fibre Test is required.
        /// 
        /// true: Dark And Medullated Fibre Test is required.
        /// 
        /// false: Dark And Medullated Fibre Test is not required.
        /// </summary>

        public bool? IsDarkAndMedullatedFibreTestRequired { get; set; }

        /// <summary>
        /// A boolean value to indicate whether Pesticide Residue Test is required.
        /// 
        /// true: Pesticide Residue Test is required.
        /// 
        /// false: Pesticide Residue Test is not required.
        /// </summary>

        public bool? IsPesticideResidueTestRequired { get; set; }
    }

}
