using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class LotPaymentDetail
    {
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
        [Required]
        public required LotIdentity LotIdentity { get; set; }

        /// <summary>
        /// This is the sum of the following amount: First Cost + (Post sale charge X total bales) + charge per lot.
        /// </summary>
        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        public required Currency LotLastCost { get; set; }
    }

}