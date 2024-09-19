using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class GuidanceReportDetail
    {
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency Charge { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required Laboratory Laboratory { get; set; }

        /// <summary>
        /// The weight of a regrab sample, a grab sample taken after the wool has been initially sampled and tested, is shown on the new certificate.
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

        [Range(-999.9,999.9)]
        public double? AirflowMean { get; set; }

        [Range(-999.9,999.9)]
        public double? Vmb { get; set; }

        [Range(-999.9,999.9)]
        public double? HardHeadsBase { get; set; }

        [Range(-999.99,999.99)]
        public double? Yield1 { get; set; }

        [Range(-999.99,999.99)]
        public double? Yield2 { get; set; }

        [Range(-999.99,999.99)]
        public double? Yield3 { get; set; }

        [Range(-999.99,999.99)]
        public double? Yield4 { get; set; }

        [MinLength(1)]
        [MaxLength(2)]
        public YieldType? YieldType1 { get; set; }

        [MinLength(1)]
        [MaxLength(2)]
        public YieldType? YieldType2 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required RetestFlag RetestFlag { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        [Range(-999.9,999.9)]
        public double? Vm1 { get; set; }

        [Range(-999.9,999.9)]
        public double? Vm2 { get; set; }

        [Range(-999.9,999.9)]
        public double? Vm3 { get; set; }
    }
}
