using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.Errors
{
    public class OrganisationNotMatchError
    {
        [MinLength(1)]
        [MaxLength(80)]
        public readonly ErrorCode ErrorCode = ErrorCode.DOXCT;

        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Explanation = "Document originator does not match current transmitter.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Reason = "The RFD document originator must match Current Transmitter.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Action = "The Request for Data transmission file needs to have the Document Originator and the Current Transmitter as the same..";
    }
}
