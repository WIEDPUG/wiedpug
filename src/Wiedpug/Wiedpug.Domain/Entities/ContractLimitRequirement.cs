using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class ContractLimitRequirement
    {
        /// <summary>
        /// The mean fibre diameter of a sample of wool measured in micrometers. This value can refer to Laserscan, Airflow or OFDA.
        ///
        /// Min: The lowest value in a range of Micron values
        ///
        /// Max: The highest value in a range of Micron values
        /// </summary>
        [Range(-999.9,999.9)]
        public double? MicronMin { get; set; }

        /// <summary>
        /// The mean fibre diameter of a sample of wool measured in micrometers. This value can refer to Laserscan, Airflow or OFDA.
        ///
        /// Min: The lowest value in a range of Micron values
        ///
        /// Max: The highest value in a range of Micron values
        /// </summary>
        [Range(-999.9,999.9)]
        public double? MicronMax { get; set; }

        /// <summary>
        /// Average yellowness, Colour Y – Colour Z. The field has an optional leading sign.
        /// 
        /// Min – The lowest value in a range of Colour-Y-Z values.
        /// 
        /// Max – The highest value in a range of Colour-Y-Z values.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourYZMin { get; set; }

        /// <summary>
        /// Average yellowness, Colour Y – Colour Z. The field has an optional leading sign.
        /// 
        /// Min – The lowest value in a range of Colour-Y-Z values.
        /// 
        /// Max – The highest value in a range of Colour-Y-Z values.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourYZMax { get; set; }

        /// <summary>
        /// Minimum VMB, optional decimal with two digits precision.
        /// </summary>
        [Range(-9.99,9.99)]
        public double? VmbMin { get; set; }

        /// <summary>
        /// Maximum VMB, optional decimal with two digits precision.
        /// </summary>
        [Range(-9.99,9.99)]
        public double? VmbMax { get; set; }

        /// <summary>
        /// The oven-dry mass of wool fibre free from all impurities, expressed as a percentage of the mass of the sample.
        /// 
        /// Min The lowest value in a range of Wool Base values
        ///
        /// Max The highest value in a range of Wool Base values
        /// </summary>
        [Range(-99.99,99.99)]
        public double? WoolBaseMin { get; set; }

        /// <summary>
        /// The oven-dry mass of wool fibre free from all impurities, expressed as a percentage of the mass of the sample.
        /// 
        /// Min The lowest value in a range of Wool Base values
        ///
        /// Max The highest value in a range of Wool Base values
        /// </summary>
        [Range(-99.99,99.99)]
        public double? WoolBaseMax { get; set; }

        /// <summary>
        /// Dichloromethane Extractable Matter (Residual Grease) remaining in a sample of wool after scouring and drying.
        ///
        /// Min: The lowest value in a range of Dichloromethane, dry basis values
        ///
        /// Max: The highest value in a range of Dichloromethane, dry basis values
        /// </summary>
        [Range(-99.99,99.99)]
        public double? DichloromethaneDryBasisMin { get; set; }

        /// <summary>
        /// Dichloromethane Extractable Matter (Residual Grease) remaining in a sample of wool after scouring and drying.
        ///
        /// Min: The lowest value in a range of Dichloromethane, dry basis values
        ///
        /// Max: The highest value in a range of Dichloromethane, dry basis values
        /// </summary>
        [Range(-99.99,99.99)]
        public double? DichloromethaneDryBasisMax { get; set; }

        /// <summary>
        /// Mass of the sample after conditioning to a specified regain.
        /// 
        /// Min: The lowest value in a range of Conditioning Mass values
        /// 
        /// Max: The highest value in a range of Conditioning Mass values
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? ConditioningMassMin { get; set; }

        /// <summary>
        /// Mass of the sample after conditioning to a specified regain.
        /// 
        /// Min: The lowest value in a range of Conditioning Mass values
        /// 
        /// Max: The highest value in a range of Conditioning Mass values
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? ConditioningMassMax { get; set; }

        /// <summary>
        /// Length after Carding Barbe in mm (mean length biased by fibre weight)
        /// 
        /// Min: The lowest value in a range of LAC Barbe values
        /// 
        /// Max: The highest value in a range of LAC Barbe values
        /// </summary>
        [Range(-999,999)]
        public int? LacBarbeMin { get; set; }

        /// <summary>
        /// Length after Carding Barbe in mm (mean length biased by fibre weight)
        /// 
        /// Min: The lowest value in a range of LAC Barbe values
        /// 
        /// Max: The highest value in a range of LAC Barbe values
        /// </summary>
        [Range(-999,999)]
        public int? LacBarbeMax { get; set; }

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
        public int? LacHauteurMin { get; set; }

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
        public int? LacHauteurMax { get; set; }

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
        public int? LacHauteurUnder20Min { get; set; }

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
        public int? LacHauteurUnder20Max { get; set; }

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
        public int? LacHauteurUnder40Min { get; set; }

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
        public int? LacHauteurUnder40Max { get; set; }

        /// <summary>
        /// Length after Carding - Coefficient of Variation of Hauteur.
        /// 
        /// Min: The lowest value in a range of LAC Hauteur CV(%) values
        /// 
        /// Max: The highest value in a range of LAC Hauteur CV(%) values
        /// </summary>
        [Range(-999,999)]
        public int? LacHauteurCvPercentMin { get; set; }

        /// <summary>
        /// Length after Carding - Coefficient of Variation of Hauteur.
        /// 
        /// Min: The lowest value in a range of LAC Hauteur CV(%) values
        /// 
        /// Max: The highest value in a range of LAC Hauteur CV(%) values
        /// </summary>
        [Range(-999,999)]
        public int? LacHauteurCvPercentMax { get; set; }
    }


}
