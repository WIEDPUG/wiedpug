using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.Errors
{
    public class TransferConfigError
    {
        [MinLength(1)]
        [MaxLength(80)]
        public readonly ErrorCode ErrorCode = ErrorCode.INVTC;

        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Explanation = "TransferConfig not valid.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Reason = "Your TransferConfig has been incorrectly specified.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Action = "Consult the AWEX Handbook or your software supplier to identify the problem.";
    }
}
