using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.Errors
{
    public class InvalidDocumentOriginatorError
    {
        [MinLength(1)]
        [MaxLength(80)]
        public readonly ErrorCode ErrorCode = ErrorCode.INVCR;

        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Explanation = "Invalid document originator code aaaaa. Data accepted.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Reason = "The document originator code on one of the TransmissionHeaders that you have sent is invalid i.e. not in the AWEX organisation data file.  Your file contains multiple TransmissionHeaders, each with a different document originator.  One of the document originator codes is invalid. All data belonging to this document originator up to the next 00 record will still be processed, but you are warned that this code is invalid.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Action = "Check the code sent.  If it seems correct, contact the Network Administrator and request that the code be added to the AWEX organisation data file.";
    }
}
