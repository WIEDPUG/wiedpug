﻿using System;
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
    /// The centreCode is one of these below based on the value of country. 
    /// The mapping of country: centreCode is the following:
    ///
    /// AU:CentreCodeAustralia
    /// 
    /// NZ: CentreNewZealand
    /// 
    /// FR: CentreFrance
    /// 
    /// ZA: CentreSouthAfrica
    /// 
    /// BE: CentreBelgium
    /// 
    /// GB: CentreUnitedKingdomofGreatBritain
    /// 
    /// DE: CentreGermany
    /// 
    /// IT: CentreItaly
    /// 
    /// NL: CentreNetherlands
    /// 
    /// CN: CentreChina
    /// 
    /// TW: CentreTaiwan
    /// 
    /// US: CentreUSA
    /// </summary> 
    public class Centre
    {
        [Required]
        [StringLength(3)]
        public required CountryCode Country { get; set; }

        [Required]
        [StringLength(2)]
        public required object CentreCode { get; set; }

        public CentreCodeAustralia? CentreAustralia { get; set; }

        public CentreCodeBelgium? CentreBelgium { get; set; }

        public CentreCodeChina? CentreChina { get; set; }

        public CentreCodeFrance? CentreFrance { get; set; }

        public CentreCodeGermany? CentreGermany { get; set; }

        public CentreCodeItaly? CentreItaly { get; set; }

        public CentreCodeNetherlands? CentreNetherlands { get; set; }


        public CentreCodeNewZealand? CentreNewZealand { get; set; }

        public CentreCodeSouthAfrica? CentreSouthAfrica { get; set; }

        public CentreCodeTaiwan? CentreTaiwan { get; set; }

        public CentreCodeUnitedKingdomOfGreatBritain? CentreUnitedKingdomOfGreatBritain { get; set; }   


        public CentreCodeUnitedStatesOfAmerica? CentreUnitedStatesOfAmerica { get; set; }







    }    
}
