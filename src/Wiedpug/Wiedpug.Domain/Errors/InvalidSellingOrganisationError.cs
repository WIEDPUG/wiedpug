using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.Errors
{
    public class InvalidSellingOrganisationError
    {
        [MinLength(1)]
        [MaxLength(80)]
        public readonly ErrorCode ErrorCode = ErrorCode.INVSO;

        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Explanation = "Invalid document originator code aaaaa. Data accepted.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Reason = "The Selling Organisation code on one of the type 10 records that you have sent is invalid, i.e. not in the WIEDPUG organisation file. All data grouped under this type 10 record will be processed and filed under the document originator code.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Action = "Check the code. If unsure contact the Network Administrator.";
    }
}
