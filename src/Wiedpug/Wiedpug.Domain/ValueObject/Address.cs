using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.ValueObject
{
    public class Address
    {
        [Required]
        public required Name Name { get; set; }

        /// <summary>
        /// Apartment, stuie, box number, P.O. Box number, etc
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public required string Premise { get; set; }

        /// <summary>
        /// Street number, street name, etc
        /// </summary>
        [Required] 
        [MinLength(1)]
        [MaxLength(80)]
        public required string StreetAddressLine1 { get; set; }

        /// <summary>
        /// Landmark, suburb, etc
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public required string StreetAddressLine2 { get; set; }

        /// <summary>
        /// Town or City
        /// </summary>
        /// 
        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public required string Locality { get; set; }

        /// <summary>
        /// State, province, region. Use ISO region codes: https://en.wikipedia.org/wiki/ISO_3166-2
        /// </summary>
        [MinLength(1)]
        [MaxLength(80)]
        public string? AdministrativeArea { get; set; }

        [MinLength(1)]
        [MaxLength(20)]
        public string? PostCode { get; set; }

        /// <summary>
        /// Use ISO 3166-1 country code: https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes
        /// 
        /// For example: AU: Australia, NZ: New Zealand, FR: France, ZA: South Africa.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required CountryCode Country { get; set; }
    }
}
