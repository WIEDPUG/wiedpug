using System.ComponentModel.DataAnnotations;

namespace Wiedpug.Domain.Entities
{
    public class InterlotComponentBaleHeader
    {
        [Required]
        public required string Brand { get; set; } // FIELD NUMBER 3 - Brand - Start: 4, Size: 30, Data Type: AN, Justification: L, Requirement Designator: M

        [Required]
        public required string BaleDescription { get; set; } // FIELD NUMBER 4 - Bale Description - Start: 34, Size: 15, Data Type: AN, Justification: L, Requirement Designator: M

        [Required]
        public required string AreaOfOrigin { get; set; } // FIELD NUMBER 5 - Area of Origin - Start: 49, Size: 4, Data Type: AN, Justification: L, Requirement Designator: C

        public string? LocationWithinStore { get; set; } // FIELD NUMBER 6 - Location - within store - Start: 53, Size: 20, Data Type: AN, Justification: L, Requirement Designator: O

        [Required]
        public int Bales { get; set; } // FIELD NUMBER 7 - Bales - Start: 73, Size: 4, Data Type: N, Justification: R, Requirement Designator: M
                
        public string? Postcode { get; set; }
    }
}
