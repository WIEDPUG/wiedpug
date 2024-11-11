using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class RecordSaleStatus
    {
        [Required]
        public required UtcDateTime FileCreationDateTime { get; set; }

        /// <summary>
        /// Required decimal field for the last cost of the first lot with two digits precision.
        /// </summary>
        [Required]
        [Range(-999999,999999)]
        public required int TotalLotsOffered { get; set; }

        /// <summary>
        /// This indicates the progress of the sale, expressed as a percentage of the total lots offered and is calculated on the WoolSaleHeaderLot record grouping.
        /// </summary>
        [Required]
        [Range(-999,999)]
        public required int PercentageSold { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the transfers are completed / Sale is finalised. 
        /// 
        /// true: Transfers are completed / Sale is finalised.
        /// 
        /// false: Transfers are not completed / Sale is not finalised.
        /// </summary>
        [Required]

        public required bool AreTransfersCompleted { get; set; }
    }

}