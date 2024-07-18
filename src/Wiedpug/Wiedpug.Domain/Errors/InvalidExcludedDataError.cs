using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.Errors
{
    public class InvalidExcludedDataError
    {
        [MinLength(1)]
        [MaxLength(80)]
        public readonly ErrorCode ErrorCode = ErrorCode.INVEX;

        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Explanation = "Invalid document originator code aaaaa. Data accepted.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Reason = "You have requested to exclude a record that is not an nominated excludable record.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Action = "Consult the AWEX Handbook RFD Chapter 24 or your software supplier to identify the problem.";
    }
}
