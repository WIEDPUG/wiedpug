using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class CatalogueLotDescription
    {
        /// <summary>
        /// This field is to be always transmitted in upper case.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public required string Brand { get; set; } // FIELD NUMBER 3 - Brand - Start: 4, Size: 30, Data Type: AN, Justification: L, Requirement Designator: M

        /// <summary>
        /// This field is to be always transmitted in upper case.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(15)]
        public required string BaleDescription { get; set; } // FIELD NUMBER 4 - Bale Description - Start: 34, Size: 15, Data Type: AN, Justification: L, Requirement Designator: M

        /// <summary>
        /// The code for the area in which the wool was grown.
        /// 
        /// For further information please go to this URL:
        /// 
        /// http://www.awex.com.au/market-information/wool-statistical-areas-wsa/
        /// </summary>
        [MinLength(1)]
        [MaxLength(4)]
        public string? AreaOfOrigin { get; set; } // FIELD NUMBER 5 - Area of Origin - Start: 49, Size: 4, Data Type: AN, Justification: L, Requirement Designator: C

        [MinLength(1)]
        [MaxLength(20)]
        public string? LocationWithinStore { get; set; } // FIELD NUMBER 6 - Location - within store - Start: 53, Size: 20, Data Type: AN, Justification: L, Requirement Designator: O

        /// <summary>
        /// Number of bales
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public int NumberOfBales { get; set; } // FIELD NUMBER 7 - Bales - Start: 73, Size: 4, Data Type: N, Justification: R, Requirement Designator: M

        [MinLength(1)]
        [MaxLength(4)]
        public string? Postcode { get; set; } // FIELD NUMBER 8 - Postcode - Start: 77, Size: 4, Data Type: AN, Justification: F, Requirement Designator: O

    }
}
