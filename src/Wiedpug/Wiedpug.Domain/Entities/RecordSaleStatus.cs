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
        [StringLength(20)]
        public required string FileCreationDateTime { get; set; }

        /// <summary>
        /// Required decimal field for the last cost of the first lot with two digits precision.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_6_DIGITS)]
        [StringLength(6)]
        public required int TotalLotsOffered { get; set; }

        /// <summary>
        /// Required decimal field for the last cost of the first lot with two digits precision.
        /// </summary>
        [Required]
        [RegularExpression(RegexPattern.NUMBER_3_DIGITS)]
        [StringLength(3)]
        public required int PercentageSold { get; set; }

        /// <summary>
        /// Boolean value to state if the transfer is completed.
        /// </summary>
        [Required]
        [StringLength(5)]
        public required bool IsTransferCompleted { get; set; }
    }

}