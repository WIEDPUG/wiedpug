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
    public class LengthAfterCardingTestDetail
    {
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required Laboratory Laboratory { get; set; }

        /// <summary>
        /// Length after Carding Barbe in mm (mean length biased by fibre weight)
        ///
        /// Min The lowest value in a range of LAC Barbe values
        ///
        /// Max The highest value in a range of LAC Barbe values
        /// </summary>
        [Range(-999,999)]
        public int? LacBarbe { get; set; }

        /// <summary>
        /// Length after Carding Barbe – Coefficient of Variation of Barbe.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? LacBarbeCvPercentage { get; set; }

        /// <summary>
        /// ength after Carding Hauteur in mm (mean length biased by cross-section of the fibres)
        /// 
        /// Min: The lowest value in a range of LAC Hauteur values
        /// 
        /// Max: The highest value in a range of LAC Hauteur values
        /// 
        /// <20 Min: The lowest value in a range of LAC Hauteur values where length is less than 20 mm
        /// 
        /// <20 Max: The highest value in a range of LAC Hauteur values where length is less than 20 mm
        /// 
        /// <40 Min: The lowest value in a range of LAC Hauteur values where length is less than 40 mm
        /// 
        /// <40 Max: The highest value in a rang
        /// </summary>
        [Range(-999,999)]
        public int? LacHauteur { get; set; }

        /// <summary>
        /// Length after Carding - Coefficient of Variation of Hauteur.
        /// 
        /// Min: The lowest value in a range of LAC Hauteur CV(%) values
        /// 
        /// Max: The highest value in a range of LAC Hauteur CV(%) values
        /// </summary>
        [Range(-999,999)]
        public int? LacHauteurCvPercentage { get; set; }

        /// <summary>
        /// Percentage Card Waste.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? LacCardWastePercentage { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency Charge { get; set; }
    }
}
