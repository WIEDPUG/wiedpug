using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    /// <summary>
    /// A group field of SellingCentre/Type and Sale Number
    ///
    /// From: The current value that the Sale Identity is to be changed from.
    ///
    /// To: The new value that the Sale Identity is to be changed to.
    ///
    /// </summary>
    public class SaleIdentity
    {
        /// <summary>
        ///
        /// SellingCentre/Type can be one of the following code:
        ///
        /// SellingCentre/Type (New Zealand):
        ///
        /// C: Christchurch; N: Napier.
        ///
        /// SellingCentre/Type (Australia):
        ///
        /// A: Adelaide; AU: Australia; B: Brisbane; F: Fremantle; G: Geelong; L: Launceston; M: Melbourne; N: Newcastle; R: Goulburn; S: Sydney; PS: Private Sales; T: Auctions Plus Sales.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public required string SellingCentreType { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        [RegularExpression(RegexPattern.NUMBER_2_DIGITS)]
        public required int SaleNumber { get; set; }
    }
}