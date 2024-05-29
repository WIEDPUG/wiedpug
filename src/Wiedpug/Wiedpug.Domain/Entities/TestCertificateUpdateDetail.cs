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
    public class TestCertificateUpdateDetail
    {
        /// <summary>
        /// Generic string field.
        /// </summary>
        [Required]
        public required string CertificateIdentity { get; set; }

        /// <summary>
        /// Enum type for reissue.
        /// </summary>
        [Required]
        public required ReissueType ReissueType { get; set; }

        /// <summary>
        /// Generic string field.
        /// </summary>
        [Required]
        public required string Client { get; set; }

        /// <summary>
        /// Numeric field.
        /// </summary>
        [Required]
        public required int Bales { get; set; }

        /// <summary>
        /// Generic alphanumeric field.
        /// </summary>
        [Required]
        public required string BaleDescription { get; set; }

        /// <summary>
        /// Decimal field with two digits after the decimal point.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DECIMAL_TWO_DIGITS)]
        public required double WoolBase { get; set; }

        /// <summary>
        /// Enum for wool preparation category, optional.
        /// </summary>
        public WoolPreparationCategory? WoolPreparationCategoryFrom { get; set; }

        /// <summary>
        /// Enum for wool preparation category, optional.
        /// </summary>
        public WoolPreparationCategory? WoolPreparationCategoryTo { get; set; }

        /// <summary>
        /// Enum for mulesing status, optional.
        /// </summary>
        public MulesingStatus? MulesingStatusFrom { get; set; }

        /// <summary>
        /// Enum for mulesing status, optional.
        /// </summary>
        public MulesingStatus? MulesingStatusTo { get; set; }

        /// <summary>
        /// Generic string field, optional.
        /// </summary>
        public string? SaleIdentityFrom { get; set; }

        /// <summary>
        /// Generic string field, optional.
        /// </summary>
        public string? SaleIdentityTo { get; set; }

        /// <summary>
        /// Generic alphanumeric field, optional.
        /// </summary>
        public string? LotIdentityFrom { get; set; }

        /// <summary>
        /// Generic alphanumeric field, optional.
        /// </summary>
        public string? LotIdentityTo { get; set; }
    }
}
