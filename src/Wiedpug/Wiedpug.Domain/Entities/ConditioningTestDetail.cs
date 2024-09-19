using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class ConditioningTestDetail
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

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required RetestFlag RetestFlag { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; }

        /// <summary>
        /// Unit in Grams.
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? MassOfGlobalSample { get; set; }

        /// <summary>
        /// Unit in Grams.
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? SumOfOdMasses { get; set; }

        /// <summary>
        /// Refer to Invoice Mass Flag to determine Gain or Loss.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight GainLossOfInvoiceMass { get; set; }

        [Required]
        [Range(-99.99,99.99)]
        public required double MoistureContentPercentage { get; set; }

        /// <summary>
        /// The amount of moisture in the fibres, expressed as a percentage of the clean oven-dry weight.
        /// 
        /// Nominated - The Regain nominated by the Test House client.
        /// 
        /// Test House - The Regain certified by the Test House.
        /// </summary>
        [Required]
        [Range(-99.99,99.99)]
        public required double RegainPercentage { get; set; }

        /// <summary>
        /// Unit in KG.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight NetWeightOdOfConsignment { get; set; }

        [Required]
        [StringLength (2)]
        public required YieldType YieldType { get; set; }

        /// <summary>
        /// Unit in KG.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(9)]
        public required Weight OfficialRegain { get; set; }

        [Required]
        [StringLength (1)]
        public required InvoiceMassFlag InvoiceMassFlag { get; set; }

        /// The date the certificate was issued.
        /// 
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>
        [Required]
        public required UtcDate DateIssued { get; set; }
    }
}
