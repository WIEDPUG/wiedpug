using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class RequestForDataParameters
    {
        public UtcDateTime? StartDateTimeStatusRequest { get; set; }

        public UtcDateTime? EndDateTimeStatusRequest { get; set; }

        /// <summary>
        /// A boolean value to indicate whether to use network datetime.
        /// true: use network datetime.
        /// false: not use.
        /// </summary>

        public bool? IsUsingNetworkDateTime { get; set; }
    }
}
