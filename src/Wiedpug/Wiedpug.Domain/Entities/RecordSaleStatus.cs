using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Shared.Constants;

namespace Wiedpug.Domain.Entities
{
    public class RecordSaleStatus
    {
        /// <summary>
        /// Datetime of the file creation with ISO UTC datetime format.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.DATE_AND_TIME_UTC_ISO8601)]
        [MinLength(1)]
        [MaxLength(20)]
        public required string FileCreationDateTime { get; set; }

        /// <summary>
        /// Required decimal field for the last cost of the first lot with two digits precision.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        [MinLength(1)]
        [MaxLength(6)]
        public required int TotalLotsOffered { get; set; }

        /// <summary>
        /// Required decimal field for the last cost of the first lot with two digits precision.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        [MinLength(1)]
        [MaxLength(3)]
        public required int PercentageSold { get; set; }

        /// <summary>
        /// A boolean value to indicate whether the transfers are completed / Sale is finalised. 
        /// 
        /// true: Transfers are completed / Sale is finalised.
        /// 
        /// false: Transfers are not completed / Sale is not finalised.
        /// </summary>
        [Required]
        [MinLength(4)]
        [MaxLength(5)]
        public required bool AreTransfersCompleted { get; set; }
    }

}