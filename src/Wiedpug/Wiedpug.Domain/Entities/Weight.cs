using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    /// <summary>
    /// coreSampleWeight: The weight of the initial core sample.
    /// 
    /// sampleWeightRemoved: The weight of wool removed after testing, to adjust the issued test results, in compliance with the relevant standard (e.g. removal of wet 
    /// wool, contract weight adjustment, retained buyer sample, etc.).
    /// 
    /// declaredGross: The gross weight of the lot as declared by the owner.
    /// 
    /// declaredTare: The tare weight of the lot as declared by the owner.
    /// 
    /// regrabSampleWeight: The weight of a regrab sample, a grab sample taken after the wool has been initially sampled and tested, is shown on the new certificate.
    /// 
    /// massOfGlobalSample: Unit in Grams.
    /// 
    /// sumOfOdMasses: Unit in Grams.
    /// 
    /// gainLossOfInvoiceMass: Refer to Invoice Mass Flag to determine Gain or Loss.
    /// 
    /// netWeightOdOfConsignment: Unit in KG.
    /// 
    /// officialRegain: Unit in KG.
    /// 
    /// conditioningMass: Mass of the sample after conditioning to a specified regain. Min: The lowest value in a range of Conditioning Mass values. Max: The highest value in a range of Conditioning Mass values.
    /// 
    /// gross: Total weight of the wool. In transmissions from Test Houses, Gross includes Regrab Sample Weight. In all other transmissions, Regrab 
    /// Sample Weight will have been subtracted from the Gross of a lot or a group before the transmission. See the chapter ‘Business Rules’ for a fuller explanation.
    /// 
    /// tare: The weight of the bale packaging.
    /// 
    /// lightestIndividualBaleWeight: This is the Reweigh Gross Kg of the lightest bale in the lot.
    /// 
    /// cleanWeight: Clean weight = Net Weight X Yield
    /// </summary>
    public class Weight
    {
        [Required]
        [Range(-999999.99,999999.99)]
        public required double Value { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(9)]
        public required WeightCode WeightCode { get; set; }
    }
}
