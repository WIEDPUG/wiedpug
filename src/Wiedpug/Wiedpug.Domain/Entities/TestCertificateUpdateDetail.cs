﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class TestCertificateUpdateDetail
    {
        /// <summary>
        /// Generic string field.
        /// </summary>
        [Required]
        [StringLength(11)]
        public required string CertificateIdentity { get; set; }

        /// <summary>
        /// Enum type for reissue.
        /// </summary>
        [Required]
        [StringLength(2)]
        public required ReissueType ReissueType { get; set; }

        /// <summary>
        /// Generic string field.
        /// </summary>
        [Required]
        [StringLength(5)]
        public required string Client { get; set; }

        /// <summary>
        /// Numeric field.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_4_DIGITS)]
        public required int Bales { get; set; }

        /// <summary>
        /// Generic alphanumeric field.
        /// </summary>
        [Required]
        [StringLength(15)]
        public required string BaleDescription { get; set; }

        /// <summary>
        /// Decimal field with two digits after the decimal point.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_4_2)]
        public required double WoolBase { get; set; }

        /// <summary>
        /// Enum for wool preparation category, optional.
        /// </summary>
        /// 
        [StringLength(1)]
        public WoolPreparationCategory? WoolPreparationCategoryFrom { get; set; }

        /// <summary>
        /// Enum for wool preparation category, optional.
        /// </summary>
        /// 
        [StringLength(1)]
        public WoolPreparationCategory? WoolPreparationCategoryTo { get; set; }

        /// <summary>
        /// Enum for mulesing status, optional.
        /// </summary>
        /// 
        [StringLength(2)]
        public MulesingStatus? MulesingStatusFrom { get; set; }

        /// <summary>
        /// Enum for mulesing status, optional.
        /// </summary>
        /// 
        [StringLength(2)]
        public MulesingStatus? MulesingStatusTo { get; set; }

        /// <summary>
        /// Generic string field, optional.
        /// </summary>
        /// 
        [StringLength(4)]
        public string? SaleIdentityFrom { get; set; }

        /// <summary>
        /// Generic string field, optional.
        /// </summary>
        /// 
        [StringLength(4)]
        public string? SaleIdentityTo { get; set; }

        /// <summary>
        /// Generic alphanumeric field, optional.
        /// </summary>
        /// 
        [StringLength(6)]
        public string? LotIdentityFrom { get; set; }

        /// <summary>
        /// Generic alphanumeric field, optional.
        /// </summary>
        /// 
        [StringLength(6)]
        public string? LotIdentityTo { get; set; }
    }
}
