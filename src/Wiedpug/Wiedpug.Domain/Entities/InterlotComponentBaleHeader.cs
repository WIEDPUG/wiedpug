using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class InterlotComponentBaleHeader
    {
        [Required]
        [StringLength(30)]
        public required string Brand { get; set; } // FIELD NUMBER 3 - Brand - Start: 4, Size: 30, Data Type: AN, Justification: L, Requirement Designator: M

        [Required]
        [StringLength(15)]
        public required string BaleDescription { get; set; } // FIELD NUMBER 4 - Bale Description - Start: 34, Size: 15, Data Type: AN, Justification: L, Requirement Designator: M

        [Required]
        [StringLength(4)]
        public required string AreaOfOrigin { get; set; } // FIELD NUMBER 5 - Area of Origin - Start: 49, Size: 4, Data Type: AN, Justification: L, Requirement Designator: C

        [StringLength(20)]
        public string? LocationWithinStore { get; set; } // FIELD NUMBER 6 - Location - within store - Start: 53, Size: 20, Data Type: AN, Justification: L, Requirement Designator: O

        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public int Bales { get; set; } // FIELD NUMBER 7 - Bales - Start: 73, Size: 4, Data Type: N, Justification: R, Requirement Designator: M

        [StringLength(4)]
        public string? Postcode { get; set; }
    }
}
