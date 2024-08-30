using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Wiedpug.Domain.Entities
{
    public class DarkAndMedullatedFibreRiskDetail
    {
        /// <summary>
        /// Enum type for declared breed.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DeclaredBreed DeclaredBreed { get; set; }

        /// <summary>
        /// Enum type for declared wool sub-category.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DeclaredWoolSubCategory DeclaredWoolSubCategory { get; set; }

        /// <summary>
        /// Enum type for declared wool category.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required DeclaredWoolCategory DeclaredWoolCategory { get; set; }

        public List<DeclaredQualifierCode>? DeclaredQualifierCodes { get; set;}

        /// <summary>
        /// Optional enum type for qualifier scale.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(1)]
        public DeclaredQualifierScale? DeclaredQualifierScale { get; set; }

        /// <summary>
        /// A boolean value to indicate whether it contact with exotic breeds.
        ///
        /// true: contact with exotic breeds.
        ///
        /// false: not contact with exotic breeds.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(5)]
        public required bool IsContactingWithExoticBreeds { get; set; }

        /// <summary>
        /// A boolean value to indicate whether it is crutched.
        /// 
        /// true: crutched.
        ///
        /// false: not crutched.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(5)]
        public required bool IsCrutched { get; set; }

        /// <summary>
        /// A boolean value to indicate whether crutching within 3 months of shearing.
        ///
        /// true: yes.
        ///
        /// false: no.
        /// </summary>
        [MinLength(4)]
        [MaxLength(5)]
        public bool? IsCrutchedWithin3MonthsOfShearing { get; set; }

        /// <summary>
        /// Enum type for sex.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required Sex Sex { get; set; }

        /// <summary>
        /// Youngest Age Code in the mob/sale lot (weight note) as per the National Wool Declaration (NWD) Age Shearing Codes.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int AgeFrom { get; set; }

        /// <summary>
        /// Oldest Age Code in the mob/sale lot (weight note) as per the National Wool Declaration (NWD) Age Shearing Codes.
        /// </summary>
        /// 
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? AgeTo { get; set; }

        /// <summary>
        /// Optional enum for dark and medullated fibre risk broker.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(1)]
        public DarkAndMedullatedFibreRiskBroker? DarkAndMedullatedFibreRiskBroker { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        public DarkAndMedullatedFibreRisk? DarkandMedullatedFibreRisk { get; set; }

        [MinLength(1)]
        [MaxLength(11)]
        public CertificateIdentity? CertificateIdentity { get; set; }

        /// <summary>
        /// The oven-dry mass of wool fibre free from all impurities, expressed as a percentage of the mass of the sample.
        /// 
        /// Min The lowest value in a range of Wool Base values
        ///
        /// Max The highest value in a range of Wool Base values
        /// </summary>
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public double? WoolBase { get; set; }

        /// <summary>
        /// A list of attributes in error.
        /// </summary>
        public List<string>? DMFRErrorFields { get; set; }
    }


}
