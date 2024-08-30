using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class PropertyIdentificationCode
    {
        /// <summary>
        /// Property Identification Code - the property code to identify the source of the wool.
        /// 
        /// This field is not used in New Zealand transmissions.
        /// </summary>
        [Required]
        public required string PIC1 { get; set; }

        /// <summary>
        /// Property Identification Code - the property code to identify the source of the wool.
        /// 
        /// This field is not used in New Zealand transmissions.
        /// </summary>
        public string? PIC2 { get; set; }

        /// <summary>
        /// Property Identification Code - the property code to identify the source of the wool.
        /// 
        /// This field is not used in New Zealand transmissions.
        /// </summary>
        public string? PIC3 { get; set; }

        /// <summary>
        /// Property Identification Code - the property code to identify the source of the wool.
        /// 
        /// This field is not used in New Zealand transmissions.
        /// </summary>
        public string? PIC4 { get; set; }

        /// <summary>
        /// Property Identification Code - the property code to identify the source of the wool.
        /// 
        /// This field is not used in New Zealand transmissions.
        /// </summary>
        public string? PIC5 { get; set; }

        /// <summary>
        /// Property Identification Code - the property code to identify the source of the wool.
        /// 
        /// This field is not used in New Zealand transmissions.
        /// </summary>
        public string? PIC6 { get; set; }

        /// <summary>
        /// Property Identification Code - the property code to identify the source of the wool.
        /// 
        /// This field is not used in New Zealand transmissions.
        /// </summary>
        public string? PIC7 { get; set; }

        /// <summary>
        /// Property Identification Code - the property code to identify the source of the wool.
        /// 
        /// This field is not used in New Zealand transmissions.
        /// </summary>
        public string? PIC8 { get; set; }

        /// <summary>
        /// Property Identification Code - the property code to identify the source of the wool.
        /// 
        /// This field is not used in New Zealand transmissions.
        /// </summary>
        public string? PIC9 { get; set; }
    }


}