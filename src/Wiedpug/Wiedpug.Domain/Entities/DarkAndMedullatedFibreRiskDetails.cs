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
    public class DarkAndMedullatedFibreRiskDetails
    {
        /// <summary>
        /// Enum type for declared breed.
        /// </summary>
        [Required]
        [StringLength(1)]
        public required DeclaredBreed DeclaredBreed { get; set; }

        /// <summary>
        /// Enum type for declared wool sub-category.
        /// </summary>
        [Required]
        [StringLength(1)]
        public required DeclaredWoolSubCategory DeclaredWoolSubCategory { get; set; }

        /// <summary>
        /// Enum type for declared wool category.
        /// </summary>
        [Required]
        [StringLength(1)]
        public required DeclaredWoolCategory DeclaredWoolCategory { get; set; }

        /// <summary>
        /// Optional enum type for qualifier code.
        /// </summary>
        /// 
        [StringLength(1)]
        public DeclaredQualifierCode? DeclaredQualifierCode1 { get; set; }

        [StringLength(1)]
        public DeclaredQualifierCode? DeclaredQualifierCode2 { get; set; }

        [StringLength(1)]
        public DeclaredQualifierCode? DeclaredQualifierCode3 { get; set; }

        [StringLength(1)]
        public DeclaredQualifierCode? DeclaredQualifierCode4 { get; set; }

        [StringLength(1)]
        public DeclaredQualifierCode? DeclaredQualifierCode5 { get; set; }

        /// <summary>
        /// Optional enum type for qualifier scale.
        /// </summary>
        /// 
        [StringLength(1)]
        public DeclaredQualifierScale? DeclaredQualifierScale { get; set; }

        /// <summary>
        /// Boolean type for contact with exotic breeds.
        /// True for contact with exotic breeds. False for not contact with exotic breeds.
        /// </summary>
        [Required]
        [StringLength(5)]
        public required bool ContactWithExoticBreeds { get; set; }

        /// <summary>
        /// Boolean type for crutched status. 
        /// True for crutched, False for not crutched.
        /// </summary>
        [Required]
        [StringLength(5)]
        public required bool Crutched { get; set; }

        /// <summary>
        /// Boolean type for crutching within 3 months of shearing.
        /// </summary>
        /// 
        [StringLength(5)]
        public bool? CrutchedWithin3MonthsOfShearing { get; set; }

        /// <summary>
        /// Enum type for sex.
        /// </summary>
        [Required]
        [StringLength(1)]
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
        [StringLength(1)]
        public DarkAndMedullatedFibreRiskBroker? DarkAndMedullatedFibreRiskBroker { get; set; }

        [StringLength(1)]
        public DarkAndMedullatedFibreRisk? DarkandMedullatedFibreRisk { get; set; }

        [Required]
        [StringLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [Required]
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public required double WoolBase { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? DMFRErrorField1 { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? DMFRErrorField2 { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? DMFRErrorField3 { get; set; }

        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public int? DMFRErrorField4 { get; set; }

    }


}
