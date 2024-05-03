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
    public class DarkAndMedullatedFibreRiskDetails
    {
        /// <summary>
        /// Enum type for declared breed.
        /// </summary>
        [Required]
        public required DeclaredBreed DeclaredBreed { get; set; }

        /// <summary>
        /// Enum type for declared wool sub-category.
        /// </summary>
        [Required]
        public required DeclaredWoolSubCategory DeclaredWoolSubCategory { get; set; }

        /// <summary>
        /// Enum type for declared wool category.
        /// </summary>
        [Required]
        public required DeclaredWoolCategory DeclaredWoolCategory { get; set; }

        /// <summary>
        /// Optional enum type for qualifier code.
        /// </summary>
        public DeclaredQualifierCode? DeclaredQualifierCode1 { get; set; }

        public DeclaredQualifierCode? DeclaredQualifierCode2 { get; set; }
        public DeclaredQualifierCode? DeclaredQualifierCode3 { get; set; }
        public DeclaredQualifierCode? DeclaredQualifierCode4 { get; set; }
        public DeclaredQualifierCode? DeclaredQualifierCode5 { get; set; }

        /// <summary>
        /// Optional enum type for qualifier scale.
        /// </summary>
        public DeclaredQualifierScale? DeclaredQualifierScale { get; set; }

        /// <summary>
        /// Boolean type for contact with exotic breeds.
        /// True for contact with exotic breeds. False for not contact with exotic breeds.
        /// </summary>
        [Required]
        public required bool ContactWithExoticBreeds { get; set; }

        /// <summary>
        /// Boolean type for crutched status. 
        /// True for crutched, False for not crutched.
        /// </summary>
        [Required]
        public required bool Crutched { get; set; }

        /// <summary>
        /// Boolean type for crutching within 3 months of shearing.
        /// </summary>
        public bool? CrutchedWithin3MonthsOfShearing { get; set; }

        /// <summary>
        /// Enum type for sex.
        /// </summary>
        [Required]
        public required Sex Sex { get; set; }

        /// <summary>
        /// Required numeric field for minimum age.
        /// </summary>
        [Required]
        public required int AgeFrom { get; set; }

        /// <summary>
        /// Optional numeric field for maximum age.
        /// </summary>
        public int? AgeTo { get; set; }

        /// <summary>
        /// Optional enum for dark and medullated fibre risk broker.
        /// </summary>
        public DarkAndMedullatedFibreRiskBroker? DarkAndMedullatedFibreRiskBroker { get; set; }
    }


}
