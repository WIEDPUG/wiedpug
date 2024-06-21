using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class SaleStatusRecord
    {
        /// <summary>
        /// Required date field for file creation.
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [RegularExpression(RegexPattern.DATE_ISO8601)]
        public required DateTime DateFileCreation { get; set; }

        /// <summary>
        /// Required time field for file creation.
        /// </summary>
        [Required]
        [DataType(DataType.Time)]
        public required DateTime TimeFileCreation { get; set; }

        /// <summary>
        /// Required numeric field for total lots offered.
        /// </summary>
        [Required]
        public required int TotalLotsOffered { get; set; }

        /// <summary>
        /// Required numeric field for percentage sold.
        /// </summary>
        [Required]
        public required int PercentageSold { get; set; }

        /// <summary>
        /// Required boolean for transfers complete status.
        /// True: transfer complete
        /// False: transfer not complete
        /// </summary>
        [Required]
        public required bool TransfersComplete { get; set; }
    }
}