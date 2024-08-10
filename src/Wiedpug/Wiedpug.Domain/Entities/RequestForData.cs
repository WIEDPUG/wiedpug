using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Interface;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class RequestForData
    {

        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        [Required]
        public required IRequestForDataType RequestForDataType { get; set; }
    }
}
