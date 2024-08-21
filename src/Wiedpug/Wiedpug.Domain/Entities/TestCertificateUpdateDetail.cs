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
    public class TestCertificateUpdateDetail
    {
        /// <summary>
        /// Generic string field.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(11)]
        public required CertificateIdentity CertificateIdentity { get; set; }

        /// <summary>
        /// Enum type for reissue.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required ReissueType ReissueType { get; set; }

        /// <summary>
        /// Generic string field.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(8)]
        public required Organisation Client { get; set; }

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
        [MinLength(1)]
        [MaxLength(15)]
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
        [MinLength(1)]
        [MaxLength(1)]
        public WoolPreparationCategory? WoolPreparationCategoryFrom { get; set; }

        /// <summary>
        /// Enum for wool preparation category, optional.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(1)]
        public WoolPreparationCategory? WoolPreparationCategoryTo { get; set; }

        /// <summary>
        /// Enum for mulesing status, optional.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(2)]
        public MulesingStatus? MulesingStatusFrom { get; set; }

        /// <summary>
        /// Enum for mulesing status, optional.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(2)]
        public MulesingStatus? MulesingStatusTo { get; set; }

        /// <summary>
        /// Generic string field, optional.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(4)]
        public SaleIdentity? SaleIdentityFrom { get; set; }

        /// <summary>
        /// Generic string field, optional.
        /// </summary>
        /// 
        [MinLength(1)]
        [MaxLength(4)]
        public SaleIdentity? SaleIdentityTo { get; set; }

        /// <summary>
        /// This is a compound name for lot number and lot suffix, where the lot 
        /// number is 5 numeric characters and the lot suffix is 1 alphanumeric
        /// character.The suffix is used when a lot is broken up by the original lot
        /// number is retained; for example.If 2 bales of a 10-bale lot got wet and
        /// the 8 bales and the 2 bales are offered separately, one could have a
        /// suffix A and the other a suffix B.Where a suffix is not used, the lot
        /// number occupies the whole of the Lot Identity field and is right justified.
        ///
        /// From:
        ///
        /// The current value that the Lot Identity is to be changed from.
        /// 
        /// To:
        /// 
        /// The new value that the Lot Identity is to be changed to.
        /// </summary>
        [MinLength(1)]
        [MaxLength(6)]
        public string? LotIdentityFrom { get; set; }

        /// <summary>
        /// This is a compound name for lot number and lot suffix, where the lot 
        /// number is 5 numeric characters and the lot suffix is 1 alphanumeric
        /// character.The suffix is used when a lot is broken up by the original lot
        /// number is retained; for example.If 2 bales of a 10-bale lot got wet and
        /// the 8 bales and the 2 bales are offered separately, one could have a
        /// suffix A and the other a suffix B.Where a suffix is not used, the lot
        /// number occupies the whole of the Lot Identity field and is right justified.
        ///
        /// From:
        ///
        /// The current value that the Lot Identity is to be changed from.
        /// 
        /// To:
        /// 
        /// The new value that the Lot Identity is to be changed to.
        /// </summary>
        [MinLength(1)]
        [MaxLength(6)]
        public string? LotIdentityTo { get; set; }
    }
}
