using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class ColourTestDetail
    {
        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required ColourTestDetailType ColourTestDetailsType { get; set; }

        /// <summary>
        /// The certificate identity consists of a 1 digit prefix, followed by an 8 digit certificate number, followed by a 1 character suffix, followed by a 1 digit check number.It is printed at the top of the certificate.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; } // FIELD NUMBER 3 - Certificate Identity - Start: 4, Size: 11, Data Type: GR, Justification: F, Requirement Designator: M

        [MinLength(6)]
        [MaxLength(15)]
        public Currency? Charge { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required Laboratory Laboratory { get; set; } // FIELD NUMBER 5 - Laboratory - Start: 21, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        /// <summary>
        /// The weight of a regrab sample, a grab sample taken after the wool has 
        /// been initially sampled and tested, is shown on the new certificate.
        /// </summary>
        [MinLength(4)]
        [MaxLength(9)]
        public Weight? RegrabSampleWeight { get; set; } // FIELD NUMBER 6 - Regrab Sample Weight - Start: 22, Size: 2, Data Type: N, Justification: R, Requirement Designator: C

        /// <summary>
        /// Colour X value.
        /// </summary>
                [Range(-999.9,999.9)]
        public double? ColourX { get; set; } // FIELD NUMBER 7 - Colour – X - Start: 24, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        /// <summary>
        /// Colour Y value.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourY { get; set; } // FIELD NUMBER 8 - Colour – Y - Start: 27, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        /// <summary>
        /// Colour Z value.
        /// 
        /// This measurement is used in New Zealand, but not in Australia.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourZ { get; set; } // FIELD NUMBER 9 - Colour – Z - Start: 30, Size: 3, Data Type: D1, Justification: R, Requirement Designator: M

        /// <summary>
        /// Average yellowness, Colour Y – Colour Z. The field has an optional leading sign.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourYZ { get; set; } // FIELD NUMBER 10 - Colour – Y – Z - Start: 33, Size: 4, Data Type: D1, Justification: R, Requirement Designator: C

        /// <summary>
        /// Min – The lowest value in a range of Colour-X values.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourXMinimum { get; set; }

        /// <summary>
        /// Max – The highest value in a range of Colour-X values.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourXMaximum { get; set; }

        /// <summary>
        /// Min – The lowest value in a range of Colour-Y values.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourYMinimum { get; set; }

        /// <summary>
        /// Max – The highest value in a range of Colour-Y values.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourYMaximum { get; set; }

        /// <summary>
        /// Min – The lowest value in a range of Colour-Z values.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourZMinimum { get; set; }

        /// <summary>
        /// Max – The highest value in a range of Colour-Z values.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourZMaximum { get; set; }

        /// <summary>
        /// Min – The lowest value in a range of Colour-Y-Z values.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourYZMinimum { get; set; }

        /// <summary>
        /// Max – The highest value in a range of Colour-Y-Z values.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourYZMaximum { get; set; }

        [MinLength(1)]
        [MaxLength(2)]
        public string? CoreBulkValue { get; set; } // FIELD NUMBER 11 - Core Bulk Value - Start: 37, Size: 2, Data Type: AN, Justification: F, Requirement Designator: C

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required ReissueChargeFlag ReissueChargeFlag { get; set; } // FIELD NUMBER 12 - Re-issue Charge Flag - Start: 39, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        /// <summary>
        /// Colour X value for scoured wool. 
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourXAsIs { get; set; } // FIELD NUMBER 14 - Colour – X (As–is) - Start: 48, Size: 3, Data Type: D1, Justification: R, Requirement Designator: C

        /// <summary>
        /// Colour Y value for scoured wool.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourYAsIs { get; set; } // FIELD NUMBER 15 - Colour – Y (As–is) - Start: 51, Size: 3, Data Type: D1, Justification: R, Requirement Designator: C

        /// <summary>
        /// Colour Z value for scoured wool.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourZAsIs { get; set; } // FIELD NUMBER 16 - Colour – Z (As–is) - Start: 54, Size: 3, Data Type: D1, Justification: R, Requirement Designator: C

        /// <summary>
        /// Colour Y – Colour Z, that is average yellowness for scoured wool.The field has an optional leading sign.
        /// </summary>
        [Range(-999.9,999.9)]
        public double? ColourYZAsIs { get; set; } // FIELD NUMBER 17 - Colour – Y – Z (As–is) - Start: 57, Size: 4, Data Type: D1, Justification: R, Requirement Designator: C

        [Required]
        [MinLength(1)]
        [MaxLength(1)]
        public required CalibrationFlag CalibrationFlag { get; set; } // FIELD NUMBER 18 - Calibration Flag - Start: 61, Size: 1, Data Type: ID, Justification: F, Requirement Designator: M

        /// <summary>
        /// The date the certificate was issued.
        /// 
        /// Date value in ISO 8601 standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD)
        /// </summary>
        [Required]
        public required UtcDate DateIssued { get; set; } // FIELD NUMBER 19 - Date Issued - Start: 62, Size: 6, Data Type: DATE, Justification: F, Requirement Designator: M
    }
}
