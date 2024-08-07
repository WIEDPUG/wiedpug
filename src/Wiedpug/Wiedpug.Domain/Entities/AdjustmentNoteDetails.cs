﻿using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class AdjustmentNoteDetails
    {
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation Client { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_8_DIGITS)]
        public required int CreditNoteInvoiceNumber { get; set; }

        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string DateOfCreditNote { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency CreditNoteAmount { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the GST is aplicable.
        /// 
        /// true: applicable.
        ///
        /// false: not applicable.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(5)]
        public required bool IsGSTApplicable { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency GSTAmount { get; set; }

        [Required]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int ReasonCode { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentityOriginal { get; set; }

        /// <summary>
        /// Date value in ISO standard UTC date format. e.g. 2024-03-21 (YYYY-MM-DD). 
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(10)]
        public required string DateOfOriginalInvoice { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity NewCertificateIdentity { get; set; }
    }
}
