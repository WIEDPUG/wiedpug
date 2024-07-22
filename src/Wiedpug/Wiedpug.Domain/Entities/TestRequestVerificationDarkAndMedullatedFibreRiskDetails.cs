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
    public class TestRequestVerificationDarkAndMedullatedFibreRiskDetails
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
        /// Boolean type for contact with exotic breeds.
        /// True for contact with exotic breeds. False for not contact with exotic breeds.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required bool IsContactWithExoticBreeds { get; set; }

        /// <summary>
        /// Boolean type for crutched status. 
        /// True for crutched, False for not crutched.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(5)]
        public required bool IsCrutched { get; set; }

        /// <summary>
        /// Boolean type for crutching within 3 months of shearing.
        /// </summary>
        /// 
        [MinLength(1)]
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
        /// Required numeric field for minimum age.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int AgeFrom { get; set; }

        /// <summary>
        /// Optional numeric field for maximum age.
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
    }


}
