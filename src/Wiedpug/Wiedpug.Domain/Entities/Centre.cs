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
    /// 
    /// centreStorage: The centre (code) representing the location at which the wool is stored (relevant to the intended use of the document). For example, the
    /// Centre- Storage against a lot in the Catalogue is the location of the wool where the buyer would expect to take delivery.
    /// 
    /// centreCatalogue: The centre (code) used to group lots of wool based on a location. This location is typically the core test/weighing centre and is often aligned with the seller’s Post Sale Charge schedule.
    /// 
    /// centreDelivery: Inclusion of the Delivery Area Centre Code is Mandatory when the Post Sale Service Charge includes delivery to a nominated area and a “D” is included in the Delivery Basis Field.
    /// 
    /// centreAlternateDelivery: This field is to be used when the PSC includes optional delivery to a second area.
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


        /**
         The following two properties are used for CentreCode "oneOf" relationship referencing when converting to OpenApi.
         Don't delete it here, they will be removed in the openapi converting process.
         The loigc is in Wiedpug.API\SchemaFilter\DiscriminatorFilter.cs
         */
        public CentreCodeAustralia? CentreAustralia { get; set; }

        public CentreCodeChina? CentreChina { get; set; }

        public CentreCodeGermany? CentreGermany { get; set; }

        public CentreCodeItaly? CentreItaly { get; set; }

        public CentreCodeNewZealand? CentreNewZealand { get; set; }

        public CentreCodeTaiwan? CentreTaiwan { get; set; }
    }    
}
