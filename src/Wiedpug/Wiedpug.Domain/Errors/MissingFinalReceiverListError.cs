using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.Errors
{
    public class MissingRinalReceiverListError
    {
        [MinLength(1)]
        [MaxLength(80)]
        public readonly ErrorCode ErrorCode = ErrorCode.INVFR;

        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Explanation = " Invalid/missing FinalReceiverList record. All data rejected.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Reason = "Your FinalReceiverList has been incorrectly specified.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Action = "Consult the AWEX Handbook or your software supplier to identify the problem.";
    }
}
