using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class TestDetail
    {
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required TestDetailType TestDetailsType { get; set; }

        [MinLength(1)]
        [MaxLength(11)]
        public CertificateIdentity? CertificateIdentity { get; set; }

        [MinLength(6)]
        [MaxLength(15)]
        public Currency? Charge { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public Laboratory? Laboratory { get; set; }

        /// <summary>
        /// The weight of a regrab sample, a grab sample taken after the wool has 
        /// been initially sampled and tested, is shown on the new certificate.
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; }

        /// <summary>
        /// The oven-dry mass of wool fibre free from all impurities, expressed as a percentage of the mass of the sample.
        /// 
        /// Min The lowest value in a range of Wool Base values
        /// 
        /// Max The highest value in a range of Wool Base values
        /// </summary>
        [Range(-99.99,99.99)]
        public double? WoolBase { get; set; }

        /// <summary>
        /// Average Fibre Diameter – Airflow
        /// </summary>
        [Range(-999.9,999.9)]
        public double? AirflowMean { get; set; }

        /// <summary>
        /// Vegetable Matter Base. The oven dry mass of ash-free, ethyl alcohol 
        /// extractives - free burrs(including hardheads), twigs, seeds, leaves
        /// and grasses present, expressed as a percentage of the mass of the
        /// greasy core sample.
        /// 
        /// Average.
        /// 
        /// The average value of vegetable matter base values for a number of lots.
        /// 
        /// Minimum.
        /// 
        /// The lowest value in a range of vegetable matter base values.
        /// 
        /// Maximum.
        /// 
        /// The highest value in a range of vegetable matter base values.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? Vmb { get; set; }

        [Range(-999.9,999.9)]
        public double? HardHeadsBase { get; set; }

        [Required]
        public required List<Yield> Yields { get; set; }


        [MinLength(1)]
        [MaxLength(1)]
        public RetestFlag? RetestFlag { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public ReissueChargeFlag ReissueChargeFlag { get; set; }

        /// <summary>
        /// The % of the core sample composed of burrs
        /// </summary>
        [Range(-999.9,999.9)]
        public double? Vm1 { get; set; }

        /// <summary>
        /// The % of the core sample composed of seeds and shive
        /// </summary>
        [Range(-999.9,999.9)]
        public double? Vm2 { get; set; }

        /// <summary>
        /// The % of the core sample composed of hardheads
        /// </summary>
        [Range(-999.9,999.9)]
        public double? Vm3 { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public DarkAndMedullatedFibreRisk? DarkAndMedullatedFibreRisk { get; set; }

        [Range(-99.99,99.99)]
        public double? AshContentDryBasis { get; set; }

        [Range(-99.99,99.99)]
        public double? AlcoholExtractableMatterDryBasis { get; set; }

        /// <summary>
        /// VMB - Minimum value.
        /// </summary>        
        [Range(-999.9,999.9)]
        public double? VmbMinimum { get; set; }

        /// <summary>
        /// VMB - Maximum value.
        /// </summary>        
        [Range(-999.9,999.9)]
        public double? VmbMaximum { get; set; }

        /// <summary>
        /// Factor for Wool Base.
        /// </summary>        
        [Range(-99999999.99,99999999.99)]
        public double? FactorWoolBase { get; set; }

        /// <summary>
        /// Factor for VMB.
        /// </summary>        
        [Range(-9999999.99,9999999.99)]
        public double? FactorVmb { get; set; }

        /// <summary>
        /// Factor for Hard Heads Base.
        /// </summary>        
        [Range(-9999999.99,9999999.99)]
        public double? FactorHardHeadsBase { get; set; }

        /// <summary>
        /// Factor for Airflow Mean. Factor used in combination calculation.
        /// </summary>
        [Range(-999999.999999,999999.999999)]
        public double? FactorAirflowMean { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public CombinationFlag? CombinationFlag { get; set; }
    }
}
