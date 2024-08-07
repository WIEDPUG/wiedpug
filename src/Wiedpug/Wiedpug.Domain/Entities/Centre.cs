using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    /// <summary>
    /// Centre has country and centreCode.
    /// 
    /// The centreCode is one of these below based on the value of country.
    /// 
    /// The mapping of country:centreCode is the following:
    ///
    /// AU:CentreCodeAustralia
    /// 
    /// NZ: CentreNewZealand
    /// 
    /// DE: CentreGermany
    /// 
    /// IT: CentreItaly
    /// 
    /// CN: CentreChina
    /// 
    /// TW: CentreTaiwan
    /// 
    /// The legacy codes for Overseas Centre are under CentreCodeAustralia
    /// </summary> 
    public class Centre
    {
        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        public required CountryCode Country { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required object CentreCode { get; set; }

        public CentreCodeAustralia? CentreAustralia { get; set; }

        public CentreCodeChina? CentreChina { get; set; }

        public CentreCodeGermany? CentreGermany { get; set; }

        public CentreCodeItaly? CentreItaly { get; set; }

        public CentreCodeNewZealand? CentreNewZealand { get; set; }

        public CentreCodeTaiwan? CentreTaiwan { get; set; }
    }    
}
