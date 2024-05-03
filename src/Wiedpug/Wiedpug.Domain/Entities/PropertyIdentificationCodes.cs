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
    public class PropertyIdentificationCodes
    {
        /// <summary>
        /// Required alphanumeric field for PIC (1).
        /// </summary>
        [Required]
        public required string PIC1 { get; set; }

        /// <summary>
        /// Optional alphanumeric field for PIC (2).
        /// </summary>
        public string? PIC2 { get; set; }

        /// <summary>
        /// Optional alphanumeric field for PIC (3).
        /// </summary>
        public string? PIC3 { get; set; }

        /// <summary>
        /// Optional alphanumeric field for PIC (4).
        /// </summary>
        public string? PIC4 { get; set; }

        /// <summary>
        /// Optional alphanumeric field for PIC (5).
        /// </summary>
        public string? PIC5 { get; set; }

        /// <summary>
        /// Optional alphanumeric field for PIC (6).
        /// </summary>
        public string? PIC6 { get; set; }

        /// <summary>
        /// Optional alphanumeric field for PIC (7).
        /// </summary>
        public string? PIC7 { get; set; }

        /// <summary>
        /// Optional alphanumeric field for PIC (8).
        /// </summary>
        public string? PIC8 { get; set; }

        /// <summary>
        /// Optional alphanumeric field for PIC (9).
        /// </summary>
        public string? PIC9 { get; set; }
    }


}