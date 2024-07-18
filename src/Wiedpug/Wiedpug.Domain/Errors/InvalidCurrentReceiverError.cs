using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.Errors
{
    public class InvalidCurrentReceiverError
    {
        [MinLength(1)]
        [MaxLength(80)]
        public readonly ErrorCode ErrorCode = ErrorCode.INVCR;

        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Explanation = "Current receiver not awtm. All data rejected.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Reason = "The current receiver code on the TransmissionHeader that you have sent is not the AWTM.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Action = "Resend the data with the correct current receiver code of AWTM.";
    }
}
